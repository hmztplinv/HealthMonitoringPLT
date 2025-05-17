Dijital Sağlık İzleme Sistemi Mikroservis Mimarisi 
Genel Mimari Yapı
Mikroservisler
SharedKernel (Ortak Çekirdek) 
o	Tüm servisler arasında paylaşılan ortak modeller
o	Ortak veri tipleri ve enumlar
o	Event tanımlamaları
o	Ortak doğrulama kuralları
o	Yardımcı fonksiyonlar ve utility sınıfları
o	Kimlik doğrulama ve yetkilendirme yapıları
o	Loglama ve izleme standartları
SharedKernel Detayları
Amaç ve Kullanım SharedKernel, mikroservisler arasında tekrarlanan kodları azaltır ve tutarlılığı artırır. Tüm servisler, bu ortak kütüphaneyi referans alacak ve servisler arası iletişimde bu ortak dili kullanacaktır.
SharedKernel İçeriği
•	Ortak Veri Modelleri: Temel hasta bilgileri, sağlık ölçüm birimleri, durum kodları
•	Ortak Olaylar (Events): Mikroservisler arası iletişimde kullanılacak standart event yapıları
•	Güvenlik Yapıları: Kimlik doğrulama token yapıları, yetkilendirme nesneleri
•	Ortak Enum'lar: Sağlık durumu, cihaz tipleri, bildirim öncelikleri gibi
•	Doğrulama (Validation) Kuralları: Tüm sistemde geçerli ortak kurallar
•	Yardımcı Fonksiyonlar: Tarih/saat işlemleri, formatlamalar, dönüşümler
Veritabanı İlişkisi SharedKernel bir veritabanına sahip değildir; yalnızca ortak kod ve tanımlamaları içerir. Her servis kendi veritabanını kullanmaya devam eder.
Deployment SharedKernel bir NuGet, Maven veya npm paketi olarak dağıtılabilir ve tüm servisler tarafından bağımlılık olarak kullanılır.

1.	Identity Service (Kimlik Servisi) 
o	Kullanıcı yetkilendirme ve kimlik doğrulama
o	Rol tabanlı erişim kontrolü (RBAC)
o	Organizasyon, tesis ve departman hiyerarşisi yönetimi
2.	Organization Service (Organizasyon Servisi) 
o	Organizasyon bilgilerinin yönetimi
o	Tesisler ve departmanların yönetimi
o	Personel atamaları ve yönetimi
3.	Patient Service (Hasta Servisi) 
o	Hasta demografik bilgileri
o	Tıbbi geçmiş
o	İlaç kullanımı
o	Hasta-cihaz ilişkileri
4.	Device Service (Cihaz Servisi) 
o	IoT cihaz yönetimi (akıllı saatler, yüzükler vb.)
o	Cihaz kaydı ve konfigürasyonu
o	Cihaz durumu izleme
5.	Vital Service (Yaşamsal Veri Servisi) 
o	IoT cihazlardan gelen verilerin işlenmesi
o	Yaşamsal verilerin gerçek zamanlı analizi
o	Anormal durum tespiti ve uyarılar
o	Doktorlar için veri görselleştirme
6.	Notification Service (Bildirim Servisi) 
o	Gerçek zamanlı bildirimler
o	E-posta, SMS, uygulama içi bildirimler
o	Acil durum uyarıları
7.	ApiGateway yarp
Protokoller ve Veri Alışverişi
Servisler Arası İletişim
Servis	Protokol	Neden
Identity Service	REST/HTTP	Standart kimlik doğrulama ve yetkilendirme istekleri için yaygın ve uygun
Organization Service	REST/HTTP	CRUD işlemleri için basit ve anlaşılır
Patient Service	REST/HTTP	CRUD işlemleri için uygun
Device Service	gRPC	Düşük gecikme, yüksek verimlilik gerektiren IoT cihaz iletişimi için ideal
Vital Service	gRPC + Event Streaming	Gerçek zamanlı veri akışı için yüksek performans
Notification Service	Event-driven (Kafka/RabbitMQ)	Asenkron bildirim işleme için uygun
IoT Cihaz Bağlantısı
Device Service, IoT cihazlara MQTT protokolü üzerinden bağlanmalıdır. MQTT, düşük güç tüketimi ve sınırlı bant genişliği olan IoT cihazlar için optimize edilmiş bir protokoldür. Device Service, cihazlardan gelen verileri alıp, işleyip Vital Service'e iletecektir.
Veri Tabanları
Servis	Veritabanı	Neden
Identity Service	PostgreSQL	İlişkisel yapı, ACID uyumluluğu, güvenlik özellikleri
Organization Service	PostgreSQL	Karmaşık organizasyon hiyerarşisi için ilişkisel model uygun
Patient Service	MongoDB	Yarı yapılandırılmış tıbbi veriler için esnek şema
Device Service	TimescaleDB	Zaman serisi verileri için optimize edilmiş PostgreSQL uzantısı
Vital Service	InfluxDB	Zaman serisi verilerini hızlı yazmak ve sorgulamak için optimize edilmiş
Notification Service	Redis	Hızlı erişim, kuyruk yapısı, geçici veri saklama
Değişiklik Yönetimi Senaryoları
1. Asistanın Departman Değişikliği
Bir asistanın departmanı değiştiğinde:
1.	Organization Service, personel kaydını günceller
2.	Organization Service, Identity Service'e bir olay (event) gönderir
3.	Identity Service, kullanıcının rollerini ve yetkilerini günceller
4.	Notification Service, ilgili personele ve yöneticilere bildirim gönderir
Bu değişiklik, Event-Driven Architecture kullanılarak gerçekleştirilmelidir. Kafka veya RabbitMQ gibi bir mesaj kuyruğu sistemi, servislerin birbirleriyle asenkron iletişim kurmasını sağlar.
2. Hastanın Tesis Değişikliği
Bir hasta aynı organizasyon içinde A Tesisinden B Tesisine geçmek istediğinde:
1.	Patient Service, hasta kaydını günceller
2.	Patient Service, Organization Service'e bir olay gönderir
3.	Organization Service, ilgili tesis kayıtlarını günceller
4.	Patient Service, Device Service'e bir olay gönderir (cihaz atamaları değişebilir)
5.	Identity Service bilgilendirilir (erişim yetkileri güncellenmesi gerekebilir)
6.	Notification Service, ilgili sağlık personeline bildirim gönderir
Veri Akışı (IoT Cihazlardan Vital Service'e)
1.	IoT cihazlar (akıllı saatler, yüzükler) → MQTT → Device Service
2.	Device Service → Veri doğrulama ve ön işleme → gRPC → Vital Service
3.	Vital Service → Veri analizi ve depolama → InfluxDB
4.	Vital Service → Gerçek zamanlı görselleştirme → Web/Mobil Uygulamalar (WebSocket)
5.	Anormal durumlar → Notification Service → İlgili doktorlara bildirim
Event-Driven Architecture Kullanımı
Bu sistemde değişiklik yönetimi için Event-Driven Architecture kullanılmalıdır. Bileşenler arasında aşağıdaki olay türleri tanımlanabilir:
•	user.role.changed
•	patient.facility.changed
•	device.assigned
•	device.data.received
•	vital.alert.triggered
API Gateway
Tüm mikroservislerin önünde bir API Gateway bulunmalıdır. Bu gateway:
•	Kimlik doğrulama ve yetkilendirme
•	Hız sınırlama
•	Yük dengeleme
•	İstek yönlendirme
•	Servis keşfi
•	Loglama ve izleme
görevlerini üstlenecektir.
Containerization ve Orchestration
Sistem, Docker containerları içinde çalışmalı ve Docker Compose ile orchestrate edilmelidir. Bu yaklaşım:
•	Kolay ölçeklendirme
•	Yüksek erişilebilirlik
•	Otomatik iyileşme
•	Kolay deployment ve geri alma
avantajlarını sağlar.
Güvenlik Katmanı
Tüm servisler arası iletişim ve harici API'ler TLS/SSL ile şifrelenmelidir. Hasta verileri için HIPAA ve GDPR gibi standartlara uyum sağlamak için ek güvenlik önlemleri alınmalıdır.


# DigiturkArticleApi
Digiturk Çok Katmanlı Mimari Makale Apisi
# Sorular ve Cevaplar
- Projede kullanıdığınız tasarım desenleri hangileridir? Bu desenleri neden kullandınız?
Service Oriented Architecture => Servis iç yapısının, servis kullanıcılarından gizlenmesi; Loosely Coupled bir yapı sağlamak.
Repository Pattern => Veritabanı işlemlerinin tek bir noktadan çıkmasını sağlamak, kod tekrarından kaçmak, ortak işlemlerin standartlaşması
- Kullandığınız teknoloji ve kütüphaneler hakkında daha önce tecrübeniz oldu mu? Tek tek
yazabilir misiniz? Evet, daha önce bir .Net Core projesinde kısa bir süre görev aldım.
Genel olarak temel Microsoft kütüphanelerini kullandım. Temel olarak .Net Core Web Api teknolojisini kulandım, Dependency Injection kütüphanesinden faydalandım.
- Daha geniş vaktiniz olsaydı projeye neler eklemek isterdiniz?
Dışarıdaki kullanıcılara daha anlaşılır bir api sunmak için swagger kütüphanesini eklemek isterdim.
Loglama ve yetkilendirme için bir ara katman(middleware) eklemek isterdim.
Kod fazlalığını ortadan kaldırmak için MvcAutoMapper kütüphanesini eklemek isterdim.
Daha güvenli ve okunabilir bir sonuçlar dönen api oluşturmak için ViewModel katmanı eklemek isterdim, veritabanından gelen sonuçları automapper yardımıyla
viewmodele basıp sonuç olarak view model dönerdim.
Veritabanına ekleme ve güncelleme işleri validasyon aspect yazmak isterdim.
Aspect Oriented Programming için bir temel hazırlamak isterdim(Log, Routing, Validation, Authorization vb).
- Eklemek istediğiniz bir yorumunuz var mı?


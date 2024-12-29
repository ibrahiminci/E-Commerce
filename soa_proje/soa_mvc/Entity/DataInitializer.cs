using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace soa_mvc.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Kamera", Description= "Kamera ürünleri"},
                new Category(){ Name = "Bilgisayar", Description= "Bilgisayar ürünleri"},
                new Category(){ Name = "Elektronik", Description= "Elektronik ürünleri"},
                new Category(){ Name = "Telefon", Description= "Telefon ürünleri"},
                new Category(){ Name = "Beyaz Eşya", Description= "Beyaz Eşya ürünleri"}
            };

            foreach (var kategori in kategoriler) {

                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name = "Canon Eos 250D 18-55mm IS STM DSLR Fotoğraf Makinesi",Description="Dünyanın hareket edebilen ekrana sahip* bu en hafif DSLR fotoğraf makinesi, klasik tutuşa ve üstün teknolojiye sahiptir. Mükemmel fotoğraflar ve 4K filmler çekmek çok kolaydır ve fotoğraf makinesi, akıllı cihazlarla sezgisel bir biçimde iletişim kurar.",Price=17229,Stock=500,IsApproved=true,CategoryId=1,IsHome=true,Image="5.jpg"},
                new Product(){Name = "Canon Eos 2000D 18-55mm DC DSLR Fotoğraf Makinesi",Description="Hoş arka plan bulanıklığına sahip anılar yaratmak ve paylaşmak için kolay, sezgisel ve ideal ilk DSLR.",Price=5400,Stock=500,IsApproved=true,CategoryId=1,Image="5.jpg"},
                new Product(){Name = "Sony ZV-E10 16-50mm Vlog Fotoğraf Makinesi",Description="Dünyayı görmeyi tercih ettiğiniz şekilde yakalayan değiştirilebilir lensler sayesinde, ZV-E10 ile profesyonel görünümlü video blog’lar üretmek çok kolaydır. Pek çok yaratıcı olasılıktan bazılarını keşfetmek için aşağıdaki videoyu izleyin.",Price=18925,Stock=500,IsApproved=false,CategoryId=1,IsHome=true,Image="5.jpg"},
                new Product(){Name = "Sony Alpha A6400 16-50mm Aynasız APS-C Fotoğraf Makinesi",Description="α6400, kompakt boyutuna ve hafif yapısına rağmen hızlı performans ve bir full frame modelden bekleyeceğiniz çeşitli özellikler sunar. İster fotoğraf ister video, ister günlük özçekimler ister yaratıcı kompozisyonlar çekin, hareket halinde paylaşmak isteyeceğiniz güzel görüntüler elde edeceksiniz.",Price=13000,Stock=500,IsApproved=true,CategoryId=1,IsHome=true,Image="5.jpg"},
                new Product(){Name = "Canon Eos 2000D 18-55mm IS DSLR Fotoğraf Makinesi",Description="Hoş arka plan bulanıklığına sahip anılar yaratmak ve paylaşmak için kolay, sezgisel ve ideal ilk DSLR.",Price=2756,Stock=500,IsApproved=false,CategoryId=1,IsHome=true,Image="5.jpg"},

                new Product(){Name = "Asus Vivobook 15 12.Nesil Core i5 1235U-8Gb-512Gb Ssd-15.6inc-W11",Description="Her yerde işleri halletmenizi kolaylaştıran, özelliklerle dolu dizüstü bilgisayar ASUS Vivobook 15 ile tarzınızı dünyaya damgalayın.",Price=16037,Stock=500,IsApproved=true,CategoryId=2,IsHome=true,Image="2.jpg"},
                new Product(){Name = "Lenovo Ideapad Slim 3 12.Nesil Core i5 12450H-8Gb-512Gb Ssd-15.6inc-W11",Description="IdeaPad Slim 3i dizüstü bilgisayar, hareket halindeyken iş, okul veya eğlence için idealdir.",Price=19701,Stock=500,IsApproved=true,CategoryId=2,IsHome=true,Image="2.jpg"},
                new Product(){Name = "Asus Vivobook 16X 12.Nesil Core i5 12450H-RTX3050 4Gb-8Gb-512Ssd-16-W11",Description="Yaratıcılığınızın sınırlarını zorlayın. ",Price=28996,Stock=0,IsApproved=false,CategoryId=2,Image="2.jpg"},
                new Product(){Name = "Casper Nirvana X600 5. Nesil Ryzen 5 5500U-8Gb-500Gb Ssd-15.6inc-W11",Description="Yüksek Performansın Ergonomik Tasarım ile Buluşması",Price=14611,Stock=257,IsApproved=true,CategoryId=2,Image="2.jpg"},
                new Product(){Name = "Asus X515ea 11.Nesil Core i3 1115G4-4Gb-256Gb Ssd-15.6inc-W11",Description="Kolay taşınabilirlik. Zahmetsiz üretkenlik.",Price=12250,Stock=1300,IsApproved=true,CategoryId=2,Image="2.jpg"},

                new Product(){Name = "iPhone 13 128 Gb Akıllı Telefon Yıldız Işığı",Description="Süper parlak bir ekran ve dayanıklı tasarım.",Price=36999,Stock=0,IsApproved=false,CategoryId=4,IsHome=true,Image="1.jpg"},
                new Product(){Name = "SAMSUNG GALAXY A34 8/256 GB AKILLI TELEFON SİYAH",Description="Galaxy A34 ile Gün ışığında bile akıcı ve parlak",Price=12250,Stock=1300,IsApproved=true,CategoryId=4,IsHome=true,Image="1.jpg"},
                new Product(){Name = "Xiaomi Redmi Note 12 Pro 8/256 Gb Akıllı Telefon Gri",Description="vivo her zaman kullanıcılarının ihtiyaçlarını öncelik olarak belirler. Kullanıcılara daha istikrarlı ve sorunsuz bir deneyim sunmak için elimizden gelenin en iyisini yapıyoruz.",Price=7.999,Stock=256,IsApproved=true,CategoryId=4,Image="1.jpg"},
                new Product(){Name = "iPhone 15 Pro Max 256 Gb Akıllı Telefon Mavi Titanium",Description="Titanyum. Çok güçlü. Çok hafif. Çok Pro.",Price=82999,Stock=100,IsApproved=true,CategoryId=4,Image="1.jpg"},
                new Product(){Name = "Alcatel-TCL 2020x Gray Tuşlu Telefon",Description="Tüm ihtiyaçlarınızı karşılar",Price=1649,Stock=0,IsApproved=false,CategoryId=4,Image="1.jpg"},

                new Product(){Name = "TCL 43P735 43inc 108 cm 4K UHD Google Smart TV,Uydu Alıcılı",Description="oltuğunuza oturun ve film yapımcılarının vermek istediği inanılmaz görüntü ayrıntılarının keyfini çıkarın.",Price=12499,Stock=765,IsApproved=true,CategoryId=3,IsHome=true,Image="4.jpg"},
                new Product(){Name = "LG 55UR81006 55inc 139 cm 4K webOS Smart TV,Uydu Alıcılı",Description="6. Nesil α5 AI 4K İşlemci ile daha akıllı bir izleme deneyimi",Price=27099,Stock=0,IsApproved=false,CategoryId=3,IsHome=true,Image="4.jpg"},
                new Product(){Name = "SAMSUNG UE 55CU8500 55inc 138 cm 4K UHD Smart TV,Uydu Alıcılı",Description="İnce kristalleri sayesinde renkler en saf haliyle gerçek hayattaki gibi",Price=32299,Stock=600,IsApproved=true,CategoryId=3,Image="4.jpg"},
                new Product(){Name = "TCL 65C745 65inc 164 cm 4K UHD Google Tv Smart Qled TV,Uydu Alıcılı",Description="Bir milyardan fazla renk tonu",Price=44299,Stock=100,IsApproved=true,CategoryId=3,Image="4.jpg"},
                new Product(){Name = "VESTEL 70Q9700TT 70inc 178 cm 4K UHD Android Smart QLED TV,Uydu Alıcılı",Description="Quantum Dot Teknolojisi",Price=2999,Stock=1200,IsApproved=true,CategoryId=3,Image="4.jpg"}
            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
        
    }
}
const express = require("express");
const app = express();
const port = 3000;

const places = [
  "Canon Eos 250D 18-55mm IS STM DSLR Fotoğraf Makinesi",
  "Sony Alpha A6400 16-50mm Aynasız APS-C Fotoğraf Makinesi",
  "Asus Vivobook 16X 12.Nesil Core i5 12450H-RTX3050 4Gb-8Gb-512Ssd-16-W11",
  "Casper Nirvana X600 5. Nesil Ryzen 5 5500U-8Gb-500Gb Ssd-15.6inc-W11",
  "iPhone 13 128 Gb Akıllı Telefon Yıldız Işığı",
  "iPhone 15 Pro Max 256 Gb Akıllı Telefon Mavi Titanium",
  "Xiaomi Redmi Note 12 Pro 8/256 Gb Akıllı Telefon Gri",
  "LG 55UR81006 55inc 139 cm 4K webOS Smart TV,Uydu Alıcılı",
  "VESTEL 70Q9700TT 70inc 178 cm 4K UHD Android Smart QLED TV,Uydu Alıcılı",
  "SAMSUNG UE 55CU8500 55inc 138 cm 4K UHD Smart TV,Uydu Alıcılı",
];

const desc = [
  "Dünyanın hareket edebilen ekrana sahip* bu en hafif DSLR fotoğraf makinesi, klasik tutuşa ve üstün teknolojiye sahiptir. Mükemmel fotoğraflar ve 4K filmler çekmek çok kolaydır ve fotoğraf makinesi, akıllı cihazlarla sezgisel bir biçimde iletişim kurar.",
  "α6400, kompakt boyutuna ve hafif yapısına rağmen hızlı performans ve bir full frame modelden bekleyeceğiniz çeşitli özellikler sunar. İster fotoğraf ister video, ister günlük özçekimler ister yaratıcı kompozisyonlar çekin, hareket halinde paylaşmak isteyeceğiniz güzel görüntüler elde edeceksiniz.",
  "Yaratıcılığınızın sınırlarını zorlayın. ",
  "Yüksek Performansın Ergonomik Tasarım ile Buluşması",
  "Süper parlak bir ekran ve dayanıklı tasarım.",
  "Titanyum. Çok güçlü. Çok hafif. Çok Pro.",
  "vivo her zaman kullanıcılarının ihtiyaçlarını öncelik olarak belirler. Kullanıcılara daha istikrarlı ve sorunsuz bir deneyim sunmak için elimizden gelenin en iyisini yapıyoruz.",
  "6. Nesil α5 AI 4K İşlemci ile daha akıllı bir izleme deneyimi",
  "Quantum Dot Teknolojisi",
  "İnce kristalleri sayesinde renkler en saf haliyle gerçek hayattaki gibi",
];

const cors = require("cors");

app.use(cors());

// Ana endpoint
app.get("/", (req, res) => {
  // Her istekte yeni bir rastgele indeks oluştur
  const randomIndex = Math.floor(Math.random() * places.length);
  const randomPlace = places[randomIndex];
  const randomDesc = desc[randomIndex];
  res.json({ place: randomPlace, desc: randomDesc });
});

// Sunucuyu başlat
app.listen(port, () => {
  console.log(`Server is running at http://localhost:${port}`);
});

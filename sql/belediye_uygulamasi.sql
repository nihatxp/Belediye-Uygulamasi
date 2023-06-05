-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 01 Oca 2023, 07:43:46
-- Sunucu sürümü: 8.0.28
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `belediye_uygulamasi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admins_table`
--

CREATE TABLE `admins_table` (
  `id` int NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Tablo döküm verisi `admins_table`
--

INSERT INTO `admins_table` (`id`, `username`, `password`) VALUES
(1, 'admin', '17e62166fc8586dfa4d1bc0e1742c08b');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cozum_masasi_basvurusu`
--

CREATE TABLE `cozum_masasi_basvurusu` (
  `basvuru_id` int NOT NULL,
  `turk_mu` tinyint(1) NOT NULL,
  `kimlik` varchar(15) NOT NULL,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(30) NOT NULL,
  `dogum_tarihi` date NOT NULL,
  `telefon` varchar(25) NOT NULL,
  `eposta` varchar(40) NOT NULL,
  `mesaj` varchar(750) NOT NULL,
  `cevap_mesaj` varchar(750) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Tablo döküm verisi `cozum_masasi_basvurusu`
--

INSERT INTO `cozum_masasi_basvurusu` (`basvuru_id`, `turk_mu`, `kimlik`, `ad`, `soyad`, `dogum_tarihi`, `telefon`, `eposta`, `mesaj`, `cevap_mesaj`) VALUES
(42, 1, '20938494322', 'Murat', ' Sari', '2022-05-12', '+905439032192', 'murat@kutahyabelediye.com', '31 Aralık 2022 tarihinde 19.30 da olan Kütahya-Bursa seferim iptal olmuş ve bana bir bilgilendirme gelmedi. Otogarda beklerken öğrendim. Aldığım bilgi de telefon numaranız olmadığından size mesaj atılmamış. Telefon numarası zorunlu alan değil ve mail adresim vardı. Güya mail atılmış ama öyle bir mail yok. \nYılbaşı günü sefer iptali ne demek siz dalga mı geçiyorsunuz insanlarla. İnsanların planı var. Siz otobüsü dolduramadınız diye böyle bir günde sefer mi iptal olur. Nasıl düşüncesiz ve kalitesizce bir yaklaşım. Şimdi benim bu hakkımı nasıl ödeyeceksiniz. Yaptığınız çok büyük terbiyesizlik. Dü', 'Merhaba,\n\nPaylaştığınız bilgilere istinaden başvurunuz oluşturuldu. Konuyu inceleyerek en kısa süre içerisinde size bilgi vereceğiz. Sağlıklı günler dileriz.'),
(43, 1, '32498423465', 'Nihat', ' Aliyev', '2022-05-12', '+905432154321', 'nihatxp@kutahyabelediye.com', 'Bir şehirde toplu taşıma ne kadar sorun olabilirse bu şehirde en az o kadar sorun. Bir otobüs ortalama 20-30 kişilikse biz 60-70 kişi biniyoruz. Oturmak zaten mümkün değil ancak artık nefes almakta bile zorluk çekiyoruz.', ''),
(44, 1, '20938494322', 'Murat', ' Sari', '2022-05-12', '+905439032192', 'murat@kutahyabelediye.com', 'Sahipsiz köpek yavruları. 7*** Mahallesi, as**s** caddesinin sonunda anneleri olmayan 2-3 aylık 8-10 tane köpek yavrusu var. Defalarca belediyeyi aradım. Bir sefer geldiler 2-3 yavruyu alıyormuş gibi yaptılar gittiler. Değişen bir şey yok. Yavrular gece gündüz bağırıyor. Belediye yok.', '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kameralar`
--

CREATE TABLE `kameralar` (
  `id` int NOT NULL,
  `kamera_adi` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kamera_url` varchar(400) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `kameralar`
--

INSERT INTO `kameralar` (`id`, `kamera_adi`, `kamera_url`) VALUES
(1, ' İstanbul Tuzla', 'https://hls.ibb.gov.tr/tkm1/hls/152.stream/chunklist.m3u8'),
(2, 'canli-esentepe-kavsagi', 'https://5a78c55e99e82.streamlock.net/esentepe/smil:esentepe/chunklist_w1725319464_b700000_tkd293emF0b2tlbmVuZHRpbWU9MTY3MjQ0NDM5NyZ3b3d6YXRva2VuaGFzaD1fOXZad2w4MmNZLUI4OW5IekUxc0FKWnpoT2R5eVVCM05xN1g1YmF2NDREa0VWb2d0S1JtZHI2QlFNX2NIOTg3Jndvd3phdG9rZW5zdGFydHRpbWU9MTY3MjQ0MjU5Nw==.m3u8'),
(3, 'KaraFatma Meydanı', 'https://5a78c55e99e82.streamlock.net/karafatma/smil:karafatma/chunklist_w1377177303_b700000_tkd293emF0b2tlbmVuZHRpbWU9MTY3MjQ0NDUyNSZ3b3d6YXRva2VuaGFzaD1TV004aC1TamFKWHByenp4ZnZIUjVvUS1QcmZpSUEzajdab3hYOXFzX0RKUHVWMVctc1NKVVI3QkpscnhzYmd0Jndvd3phdG9rZW5zdGFydHRpbWU9MTY3MjQ0MjcyNQ==.m3u8'),
(4, 'vakif-kent-parki', 'https://5a78c55e99e82.streamlock.net/VakifKentParki/smil:VakifKentParki/chunklist_w719700400_b700000_tkd293emF0b2tlbmVuZHRpbWU9MTY3MjQ0NDYyNCZ3b3d6YXRva2VuaGFzaD1CRU00Tnk1MXk3Q3FseXVGaTdpcTBPdlJjVzE4amc5M0FESk1LeXVDZFdBRi1UVnZnbjFKRnVDUlphVlFwS19kJndvd3phdG9rZW5zdGFydHRpbWU9MTY3MjQ0MjgyNA==.m3u8'),
(5, 'kulturpark', 'https://5a78c55e99e82.streamlock.net/kulturpark/smil:kulturpark/chunklist_w942308962_b700000_tkd293emF0b2tlbmVuZHRpbWU9MTY3MjQ0NDY4NCZ3b3d6YXRva2VuaGFzaD1KVEZsQlp3SG4zR0ViYmw4eVRjQ3FmLS1XMmc2NXc2M29SQ2pxRmVPRU93dlJTV3FBd1FQcGFPZlBtNzJ3VWJsJndvd3phdG9rZW5zdGFydHRpbWU9MTY3MjQ0Mjg4NA==.m3u8');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `otobus_bilgileri`
--

CREATE TABLE `otobus_bilgileri` (
  `id` int NOT NULL,
  `No` varchar(5) NOT NULL,
  `isim` varchar(35) NOT NULL,
  `gidis` varchar(600) NOT NULL,
  `donus` varchar(600) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Tablo döküm verisi `otobus_bilgileri`
--

INSERT INTO `otobus_bilgileri` (`id`, `No`, `isim`, `gidis`, `donus`) VALUES
(1, 'A1', 'A1 (Zafertepe-Merkez Kampüs) Nolu H', 'Zafertepe -İmam Gazali Cad.-KYK-Dumlupınar Bul.(Atakent Alt Yolu)-Fatih Sultan Mehmet Bulv.(Karayolları)-Vazo Kavşağı-Adnan Menderes Bul.-Ahmet Derin Cad.-Bölcek Yolu-Çevre Yolu-Merkez Kampüs', 'Merkez Kampüs-Çevre Yolu-Bölcek Yolu-Ahmet Derin Cad.-Adnan Menderes Bul.-Vazo Kavşağı-Fatih Sultan Mehmet Bulv.(Karayolları)-Dumlupınar Bul.(Atakent Alt Yolu)-KYK-İmam Gazali Cad.-Zafertepe'),
(2, '2', '2 (Nafi Güral Fen Lisesi-Evliya Çel', 'NAFİ GÜRAL Fen Lisesi-ERKA Çarşı-Göçmen Sk.-Mahir Ablum Cad.-Kent Hastanesi Önü-Dumlupınar Bul.-Ticaret Sanayi Odası-Bekir Sıtkı Paşa Cad.(Atakent)-Seyfi Efendi Sokak-Atakent Muhtarlığı-Hacı Asım Öğütçü Cd.-F. Sultan Mehmet Bul.-Maliye-Devlet Hastanesi-Saat Kulesi-Menderes Cad.-Osmanlı Cad.-Hürriyet Cad.-Lala Hüseyin Paşa Cad.-Hamam Cad.-Ertuğrul Gazi Cad.-E. Çelebi Devlet Hastanesi-Nafia Garaj Yolu Cad.-Dörtyol Camii-Hasan Polatkan Cad.- Şenbel Cad.-Hafız Ahmet Efendi Cad.-Zafer İlkokulu-Akbayır Cad.-Hafız Mehmet Emin Efendi Cad.-Çamlıca Yurdu', 'Çamlıca Yurdu-Hafız Mehmet Emin Efendi Cad.-Hasan Polatkan Cad.-Akbayır Cad.-Zafer İlkokulu-Hafız Ahmet Efendi Caddesi-Şembel Caddesi-Nafia Garaj Yolu Cad.-E. Çelebi Devlet Hastanesi-Ertuğrul Gazi Cad.-Ulucamii Cad.-Analcı Mescid Sk.-Belediye İşhanı-Saat Kulesi Sk.Devlet Hatun Cad.-Vecide Sk.-Servi Sokak.-Menderes Cad.-Saat Kulesi Önü-F. Sultan Mehmet Bul.-Devlet Hastanesi-Maliye-Hacı Asım Öğütçü Cad.-Atakent Muhtarlığı-Seyfi Efendi Sokak-Bekir Sıtkı Paşa Cad.(Atakent)-Ticaret Sanayi Odası-Dumlupınar Bul-Kent Hastanesi Önü(Dumlupınar Bul)- ERKA Çarşı NAFİ GÜRAL Fen Lisesi'),
(3, '3', '3 (Evliya Çelebi-Zafertepe) Nolu Ha', 'Çamlıca Yurdu-Hasan Polatkan Caddesi-Hafız Mehmet Emin Efendi Caddesi (U dönüş)- Hasan Polatkan Caddesi.-Altınbilek Cad.-Hasan Polatkan Cad.-Akbayır Cad.- Zafer İlkokulu- Hafız Ahmet Efendi Caddesi-Irmak Sok.-Şair Ali Pesendi Cad.-Okmeydanı Hisar Kavşağı-Gediz Cad.-Sultanbağı Cad.-Eğdemir Sokak-Belediye İşhanı-Saat Kulesi Sk.-Devlet Hatun Cad.-Servi Sokak-Menderes Cad.-Saat Kulesi-Fatih Sultan Mehmet Bul.-Devlet Hastanesi-Maliye-Karayolları-Nizamiye-Gümüşpala Cad.-Şelale Camisi- akçay cad.-Hüzzam sok.', 'Akçay Cad.-Hüzzam sok.-Selimiye Cad.-Selimiye Cami-Gümüşpala Cad.-Nizamiye- Fatih Sultan Mehmet Bul.-Karayolları-Maliye-Devlet Hastanesi-Menderes Cad.-Osmanlı Cad.-Sultan Bağı Cad.-Gediz Cad.-Okmeydanı Hisar Kavşağı-Şair Ali Pesendi Cad.-Irmak Sok.-Hafız Ahmet Efendi Cad.-Zafer İlkokulu-Akbayır Cad.-Hasan Polatkan Cad.- Hafız Mehmet Emin Efendi Caddesi (U dönüş)- Hasan Polatkan Caddesi.-Çamlıca Yurdu'),
(4, '4', '4 (Zafertepe-Hastane) Nolu Hat', 'Zafertepe-Engelliler Okulu-Taç Mahal Cad.-Cihanşah Sok.-Şeyh Edebali Cad.-Selahaddin Eyyübi Cad.-Dr. Sadık Ahmet Cad.-KYK-Germiyan Kampüsü-Dumlupınar Bul.-Mescidi Aksa Cad.-Kalyoncu Sok.-Şelale Camii-Sancak Sokak-Gümüş Pala Cad.-Yenidoğan ilköğretim Okulu-Nizamiye- Fatih Sultan Mehmet Bul.-Maliye-Devlet Hastanesi-Saat Kulesi-Adnan Menderes Bul.-Emniyet-Sanayi kavşağı.-Dört Yol Kavşağı.-Nafia Garaj Yolu.-Hastane', 'Hastane.-Hal Sokak.-L.H.Paşa Cad.-Sanayi Sok.-Menderes Cad.-Emniyet-Osmanlı Cad-Belediye İşhanı-Saat Kulesi Sok.-Devlet Hatun Cad.-Servi Sokak-Menderes Cad.-Saat Kulesi Önü-Devlet Hastanesi-Maliye-Nizamiye- Gümüş Pala Caddesi –Yenidoğan ilköğretim Okulu-Şelale Camii-Kalyoncu sok.-Dekor sok.- Dumlupınar Bulv.-Kent Hastanesi-Germiyan Kampusü-KYK- Dr. Sadık Ahmet Cad.-Selahaddin Eyyübi Cad.-Şeyh Edebali Cad.-Cihanşah Sok.-Taç Mahal Cad.-Engelliler Okulu-Zafertepe.\n'),
(5, '5', '5 (Zafertepe-Bahçeli Evler) Nolu Ha', 'Zafertepe.-İmam Gazali Cad.-Şeyh Edebali Cad.-Selahattin Eyyubi Cad.-İmam Evleri-Zafer Cad.-Embiya Cad.-Taberi Sok.-Adiller Cad. Sadiye Sok.-Balaban Sok.-Gaziantep Cad.-Akşemsettin Camii-Yunus Emre Cad..-Mekke Camii-Hayme Ana Cad.-Mevlana Cad.-Ş.H. Kurban Sok.-Ferace Sok.-Polis Lojmanları-Ali Güral Lisesi-M. Akif Ersoy Cad.-Bahçeli Sok.-Ufuk Sok.-İl Sivil Savunma Müdürlüğü-Abdurrahman Karaa Bul.-Eski SSK-Kılıç Badem Sok.-43 Evler Cad.-Akif Sok.-İkbal Sok.- Trafik Pisti-Makine İkmal Kavşağı-Atatürk Bul.-Menderes Cad.-Osmanlı-Hürriyet Cad.-Lala Hüseyin Paşa Cad.-Hal Sok.-Evliya Çelebi Hastanesi-', 'Mehmet Akif Ersoy Mah.-Sıhhat Sok.-Mersinli Ahmet Sok-Şht. Şekip Erdem Cad.-Hasan Polatkan Cad.-Dört Yol Cami-Nafia Garaj Yolu Cad.-Evliya Çelebi Hastanesi-Hal Sok.-Kıbrıs Cad.-Samanpazarı-Meydan Cad.-Menderes Cad.-Osmanlı Cad.-Belediye İşhanı-Saat Kulesi Sok.-Asım Gündüz Cad.-Domaniçler Petrol-Laleli-Makine İkmal Kavşağı-Trafik Pisti-İkbal Sok.-Akif Sok.-43 Evler Cad.-Kılıç Badem Sok.-Eski SSK-Abdurrahman Karaa Bul.-İl Sivil Savunma Müdürlüğü-Ufuk Sok.-Bahçeli Sok.-M.Akif Ersoy Cad.Ali Güral Lisesi-Polis Lojmanları-Serhat Sok.-Mevlana Cad.-Hayme Ana Cad.-Yunus Emre Cad.-Akşemsettin Cami-Gazia'),
(6, '6', '6 (Zafertepe-Toki) Nolu Hat', 'Zafertepe Son Durak -Engelliler Okulu-Taç Mahal Cad.-Cihanşah Sok.-Şeyh Edebali Cad.-İmamı Gazali Cad.-KYK-Germiyan Kampüsü- Servis Yolu- Derviş Hüsam Caddesi- Şehit Ömer Halis Demir Caddesi-Sporkent Üst Geçidi-Akşemseddin Camii-Yunus Emre Cad.- Fevzi Çakmak Caddesi-DSİ Kavşağı-Erdoğan Atasoy Cad.-Algömlek Sok.-Hacı Hıfzı Emer Cad.-Laleli Camii-Atatürk Bulvarı-Vazo Kavşağı-Adnan Menderes Bulvarı-Osmanlı Caddesi.- Hürriyet Cad.-Lala Hüseyin Paşa Cad.-Hamam Cad.-Zafer Cami-Evliya Çelebi Hastanesi- Nafia Garaj Yolu Cad.-Dört Yol Kavşağı- Adnan Menderes Bulvarı- Sanayi Kavşağı-Sakıp Sabancı Cad.-B', '627 Küme Evleri- Türkmen Caddesi.- Şehit Polis Melih Çimen Cad.-Bursa Cad.- Muhsin Yazıcıoğlu Cad.- Şehit İtfaiye Eri Ömer TÜRK Sok.-Süleyman Efendi Cad.- 5.Ak Sokak.- 6.Ak Sokak.- Barış Pınarı Bulvarı-Toki Köprüsü- Fatih Sanayii Cad.-Bereket Cad.-Sakıp Sabancı Cad.-Adnan Menderes Bulvarı- Dört Yol Kavşağı - Nafia Garaj Yolu Cad.- Evliya Çelebi Hastanesi- Ertuğrul Gazi Caddesi-Analcı Mescit Sokak-Saat Kulesi Sokak- Org. Asım Gündüz Caddesi-Vazo Kavşağı-Atatürk Bulvarı- Laleli Camii- Hacı Hıfzı Emer Cad- Sebilerenler Camii- DSİ Kavşağı- Fevzi Çakmak Cad.- Yunus Emre Cad.- Akşemseddin Camii- Spo'),
(7, '7', '7 (Belediye-Merkez Kampüs) Nolu Hat', 'Eski Otogar-Laleli Camii-Atatürk Bulv.-Mithat Paşa Cad.-Kobak-Eski Emniyet Müdürlüğü-Dört Yol Cami-Ahmet Derin Cad.-Bölcek Mah.-Özçınarlar Kavşağı-Tavşanlı Yolu-Merkez Kampüs\n', 'Merkez Kampüs-Bölcek Mah.-Ahmet Derin Cad.-Menderes Cad.-Kobak-Mithat Paşa Cad.-Merkez Sok.-Çinigar Cad.-Eski Otogar'),
(8, '7A', '7A (Otogar-Merkez Kampüs) Nolu Hat', 'Otogar Arkası-Eskişehir Yolu (Şehir istikameti)-Atatürk Bulvarı- Menderes Cad.-Ahmet Derin Caddesi-Bölcek-Çevre Yolu-Merkez Kampüs', 'Merkez Kampüsü-Çevre Yolu-Bölcek-Ahmet Derin Caddesi- Menderes Cad.-Atatürk Bulvarı- Eskişehir Yolu (Eskişehir istikameti)-Otogar Arkası'),
(9, '7B', '7B (Can çini-Merkez Kampüs) Nolu Ha', 'Can Çini Cafe-Taberi Sokak-Embiya Sokak-Hacı Mustafa Önsay Caddesi-Adiller Caddesi-Akşemseddin İmam Hatip Lisesi-Selimiye Caddesi(Akşemseddin Camii)-Yunus Emre Caddesi-(Yenidoğan Kanal Boyu)-Tugay Yolu (Mekke Camii)-Alayunt Sokak(Tugay)-Tugay Vefa Psikiyatri Hastanesi-Vefa Üstgeçidi-TCDD Tren Garı-Abdurrahman Karaa Bulvarı (İstasyon Caddesi)-Fevzi Çakmak Caddesi( D.S.İ.)-Erdoğan Atasoy Caddesi-Algömlek Sokak-Hacı Hıfzı Emer Caddesi(Laleli Kavşağı)-Atatürk Bulvarı-Menderes Cad.-Osmanlı Cad.-Hürriyet Caddesi-Lala Hüseyin Paşa Caddesi(Tahıl Pazarı Üzeri)-Hal Sokak-Nafia Garaj Yolu-Evliya Çelebi D', 'Merkez Kampüs-Bölcek Mahallesi-Ahmet Derin Caddesi-Dörtyol Kavşağı (Dörtyol Cami)-Evliya Çelebi Devlet Hastanesi(Ana Bina)-Ertuğrul Gazi Caddesi(Zafer Cami)-Hisar Altı-Analıca Mescid Sokak-Belediye İşhanı- Saat Kulesi Sokak-Asım Gündüz Cad.-VAZO-Atatürk Bulvarı- Domaniçler Petrol-Lalel Kavşağı-Hacı Hıfzı Emer Caddesi-Fevzi Çakmak Caddesi(D.S.İ.)-Abdurrahman Karaa Bulvarı-Vefa Üstgeçidi-Alayunt Sokak(Tugay Vefa Psikiyatri Hastanesi)-Tugay-Mekke Camii-Yunus Emre Caddesi(Yenidoğan Kanal Boyu)-Selimiye Caddesi(Akşemseddin Camii)-Akşemseddin İmam Hatip Lisesi-Adiller Caddesi-Hacı Mustafa Önsay Cadd'),
(10, '8', '8 (1453 Konutları-Vazo) Nolu Hat', '1453 Konutları.- Toki 3.etap.-Şehzadeler Parkı.-Kişgem.-İstek Okulları.-Modern Evler.-Fatih Rüştü Zorlu Cad.- SGK .-Adnan Menderes Bulvarı.-Dörtyol.-Nafia Garaj Cad.-Evliya Çelebi Devlet Hastanesi Ana Bina.-Ertuğrul Gazi Cad.-Ulu Camii Cad.-Analıca Mescid Cad.-Belediye İş Hanı.-Org.Asım Gündüz Cad.-Vazo.', 'Vazo.- Adnan Menderes Bulvarı.-SGK .-Fatih Rüştü Zorlu Cad.-Modern Evler.-İstek Okulları.-Kişgem.-Şehzadeler Parkı.-Toki 3.etap.-1453 Konutları.'),
(11, '9', '9 (Ok meydanı-Otogar) Nolu Hat', 'Palamut Sokak.-100.Yıl İÖO-Aydınlık Evler Cad.-Reha Caddesi-Asil Sok.-Şair Ali Pesendi Cad.-Hisar Kavşağı-Soğuk Çeşme Cad.-Sultanbağı Cad.-Cumhuriyet cad.-Asım Gündüz Cad.-Domaniçler Petrol-Atatürk Bulvarı-Laleli Camii-Kütahya Eskişehir Yolu Gidiş İstikameti-Otogar.\n', 'Otogar-Kütahya Eskişehir Yolu Geliş İstikameti-Atatürk Bulvarı-Laleli Cami- Hilton Önü-Menderes Cad.-Osmanlı Cad.-Ulu Camii-Sultanbağı Cad.-Soğuk Çeşme Caddesi-Hisar Kavşağı- Şair Ali Pesendi Caddesi-Asil Sok.-Reha Caddesi- Aydınlık Evler Cad. -100. Yıl İ.Ö.O.-Palamut Sokak.-\n'),
(12, '10', '10 (Göker Evleri-Sazak) Nolu Hat', 'Sazak Aksu Camii-Hoca Ahmet Yesevi Cad.-Huzur Evi-Beşikkaya Cad.-Hacı Okka Cad.-Özbek Camii-Maltepe Cad.-Leylak Sokak-Sırt Sokak- Şeker Sokak-Pilot Sok.-Pilot Cad.-Salep Sk.-Kanare Sk.-Şeyh Bekir Efendi Sk.-Süleymanşah Sok. -Fatih Sultan Mehmet Bulv.-Karayolları-Maliye-Devlet Hastanesi(ek bina)-Kervan Lokantası- Fatih Sultan Mehmet Bulv.-Hürriyet Cad.-Lala Hüseyin Paşa Cad.-Hal Sok.-Evliya Çelebi Devlet Hastanesi- Nafia Garaj Yolu Cad.-Dörtyol Camii-Ahmet Derin Cad.-Hekim Sinan Bulvarı.-Bülent Erklavuz Cad.-Türkmen Cad.(Göker Evleri.)', 'Türkmen Cad(Göker Evleri).-Şht.Uz.Çvş Hasan Yaşar Cad Hekim Sinan Bulvarı.-Ahmet Derin Cad.- Dörtyol Camii-Nafia Garaj Yolu-Evliya Çelebi Devlet Hastanesi.-Ertuğrul Gazi Cad.-Belediye Sok.-Saat Kulesi Sk.-Vecide Sk.-Çatal Sk.-Akabe Sk.-Menderes Cad.-Saat Kulesi Önü - Fatih Sultan Mehmet Bulv.-Devlet hastanesi(ek bina)-Maliye-Karayolları- Şeyh Bekir Efendi Sok.-Mezbaha Sok.-Tarçın Sok.-Salep Sok.-Pilot Cad.-Pilot Sok.-Şeker Sok.-Sırt Sok.- Leylak Sok.-Maltepe Cad.-Özbek Camii- Hacı Okka Cad.-Beşikkaya Cad.-Huzur Evi-Ahmet Yesevi Cad.-Sazak Aksu Camii'),
(13, '12', '12 (Kırcı-Parmakören-Ceza İnfaz Evi', 'Kütahya Ceza İnfaz Evi - Parmakören Mah.-Makine İkmal Yan Yol.-Toki Kavşağı.-Kişgem.-Toki Kavşağı-Ahi Evren Cad.- Dörtyol-E. Çelebi Hastanesi-Ertuğrul Gazi Cad.-Ulu Cami Cad.-Analıca Mescid Sok.-Belediye İşhanı-Saat Kulesi Sok.-Asım Gündüz Cad.-Atatürk Bul.-Çinigar Cad.-Göktürk Cad.-Aydınlık Cad.-Şule Mete Tetik İmamhatip- Bekir Avlupınar Cad.- Kırcı Petrol', 'Kırcı Petrol-Bekir avlupınar Cad.-Şule Mete Tetik İmamhatip.-Aydınlık Cad.-Göktürk Cad.-Bekir Avlupınar Cad.-Laleli-Atatürk Bul.-Menderes Cad.-Osmanlı Cad.-Hürriyet Cad.-Lala Hüseyin Paşa Cad.-Hamam Cad.-Ertuğrul Gazi Cad.-Nafia Garaj Yolu Cad.-Adnan Menderes Bul.-Ahi Evren Cad.-Toki Kavşağı.-Kişğem.-Parmakören Mah.- Kütahya Ceza İnfaz Evi'),
(14, '13', '13 (Transfer-1.Organize) Nolu Hat', 'Organize Sanayi-Akdaş Kimya önü-Organize Müdürlüğü- Gürok A.Ş.-Alayunt-İkizhöyük-Zığra-Tugay-Tugay Yolu-Yunusemre Cad.-Fevzi Çakmak Cad-D.S.İ.-Abdurrahman Kara Bulvarı-Domaniçler Petrol İstasyonu.', 'Domaniçler Petrol İstasyonu-Atatürk Bulv.-Laleli-DSİ-Fevzi Çakmak Cad.- Yunusemre Cad.- Tugay Yolu-Tugay-Zığra-İkizhöyük-Alayunt- Gürok A.Ş.- Organize Müdürlüğü- Akdaş Kimya önü-Organize Sanayi'),
(15, '14', '14 (Domaniçler Pet.- Barışpınar Bul', 'Şok Market Üstü - Hilal Kent Mahallesi 1453 Konutları- Barışpınar Bulvarı- 5. Ak sokak-Süleyman Efendi Cad.-Şht.İtf. Eri Ömer TÜRK Sok.-Muhsin Yazıcıoğlu Cad.-Bursa Cad.-Şht.Pol Melih Çimen Cad.-İnköy-Eskişehir Yolu-Otogar-Atatürk Bulv.-Laleli Camii-Sebilerenler Cad.-Domaniçler Petrol.', 'Domaniçler Petrol.-Atatürk Bulv.- Laleli Camii-Otogar- Eskişehir Yolu-İnköy.-Türkmen (627 Küme Evleri) Cad.-Buğra Han Sok.- Şht.İtf. Eri Ömer TÜRK Sok.-7.Ak Sok..- Barışpınar Bulvarı- Hilal Kent Mahallesi 1453 Konutları - Şok Market Üstü'),
(16, '15', '15 (Transfer-Kamyon garajı) Nolu Ha', 'Kamyon Garajı-Kümaş- Otogar- Atatürk Bulv.-Laleli Camii-Domaniçler Petrol İstasyonu.\n', 'Domaniçler Petrol İstasyonu.-Atatürk Bulv.-Laleli Camii-Otogar-Eskişehir Yolu- Kümaş-Kamyon Garajı.'),
(17, '16', '16 (KYK Yurtlar-Merkez Kampüs) Nolu', 'Kampüs Son Durak.-Olimpik Havuz.-Kampüs Ana Giriş Kapısı.-Alt Geçit.- Andız Geven Yolu.-Hazer Dinari Erkek Yurdu.-Tri Müjgan Kız Yurdu. Dönüş: Tri Müjgan Kız Yurdu.-Alt Geçit Yan yol.-Alt', 'Kampüs Ana Giriş Kapısı-Olimpik Havuz.- Kampüs Son Durak.'),
(18, '17', '17 (Toki-Merkez Kampüs) Nolu Hat', 'Akkent Mahallesi(3.Etap-2.Etap-1.Etap)-Mikromarket-Turgutlar Yolu-Çevre Yolu-Merkez Kampüs', 'Merkez Kampüs-Çevre Yolu-Turgutlar Yolu-Mikromarket-Akkent Mahallesi (1.Etap-2.Etap-3.Etap)'),
(19, '20', '20 (Demirciören-Otogar) Nolu Hat', 'Demirciören-Sofu Mahallesi-Güveçci Mahallesi-Okçu Mahallesi-Çamlıca Caddesi-Altınbilek Cad.(Cemevi)-Hasan Polatkan Caddesi-Nafia Garaj Yolu Caddesi-E.Çelebi Hastanesi-Hal Sokak-Kıbrıs Caddesi-Meydan Caddesi-Adnan Menderes Bulvarı-Osmanlı Cad.-Belediye İşhanı-Saat Kulesi Sok.-Asım Gündüz Cad.-Abdurrahman Karaa Bul.-İstasyon Cad.-Alayunt Sok.-Zığra Sok.-Fazilet Sok.-Şehit Akif Yetkin Cad.-Vefa Mah.- Fuar Alanı-Perli Küme evleri Yolu- Otogar.', 'Otogar-Perli Küme evleri Yolu-Fuar Alanı-Vefa Mah.-Şehit Akif Yetkin Cad.-Alayunt Sok.-İstasyon Kavşağı(Tren Garı).-İstasyon Cad.-Abdurrahman Karaa Bul.-Menderes Cad.-Osmanlı Cad.-Hürriyet Cad.-Analcı Mescit Sokak-Hürriyet Caddesi-Lala Hüseyin Paşa Cad.-Hal Sokak-E.Çelebi Hastanesi-Nafia Garaj Yolu-Hasan Polatkan Cad. -Altınbilek Cad.(Cemevi)-Çamlıca Caddesi-Okçu Mahallesi-Güveçci Mahallesi-Sofu Mah.- Demirciören'),
(20, '21', '21 (Domaniçler-Yoncalı) Nolu Hat', 'Hilton Oteli-Menderes Cad.-Dörtyol Camii- Ahmet Derin Cad.-Bölcek Mahallesi-Çevre Yolu-Üniversite Lojmanları-Yoncalı', 'Yoncalı- Üniversite Lojmanları -Çevre yolu-Bölcek Mah.-Ahmet Derin cad.-Dörtyol Camii-Menderes Cad-Saat Vazo Kavşağı-Atatürk Bulvarı-Domaniçler Petrol.'),
(21, '22', '22 (Domaniçler-Ilıca) Nolu Hat', 'Domaniçler Petrol İstasyonu-Atatürk Bulv.-Laleli Camii- Kütahya Eskişehir Yolu-Ilıca', 'Ilıca-Kütahya Eskişehir Yolu-Laleli Camii-Atatürk Bulv.-Domaniçler Petrol İstasyonu.'),
(22, '23', '23 (Yeni Belediye-Enne) Nolu Hat', 'Yeni Belediye-Laleli Camii- Hilton Oteli- Menderes Cad.-Ahmet Derin Caddesi-Kuyu Cad.-Bölcek Camii-Okul Cad.-Bölcek Mahallesi-Dumlupınar Mahallesi-Şair Şeyhi Caddesi-Kirazpınar Mahallesi-Civli Mahallesi-Enne.', 'Enne-Civli Mahallesi-Kirazpınar Mahallesi-Şair Şeyhi Caddesi-Dumlupınar Mahallesi-Bölcek Mahallesi-Okul Cad.-Bölcek Camii-Kuyu Cad.-Ahmet Derin Caddesi- Menderes Cad.-Atatürk caddesi-Domaniçler Petrol.'),
(23, '24', '24 (Domaniçler-Yeni Bosna Perli) No', 'Domaniçler Petrol İstasyonu-Atatürk Bul.-Laleli Camii-Kütahya-Eskişehir Yolu (Gidiş İstikameti)- Yeni Bosna Mah.-Perli Mah.', 'Perli Mah.- Kütahya-Eskişehir Yolu (Geliş İstikameti)Atatürk Bul. –Laleli Camii-Domaniçler Petrol İstasyonu. '),
(24, '25', '25 (Yeni Belediye-Andız-Geven-İshak', 'Yeni Belediye .-Laleli Camii-Hilton Oteli- Menderes Cad.-Ahmet Derin Caddesi-Bölcek Mahallesi-Çevre yolu.-Andız Mahallesi-Geven Mahallesi-İshak Seydi Mahallesi.', 'İshak Seydi Mahallesi-Çevre Yolu (Geliş İstikameti)Bölcek Mahallesi-Ahmet Derin Caddesi- Menderes Cad.-Atatürk caddesi-Domaniçler Petrol İstasyonu.'),
(25, '26', '26 (Zafertepe-Otogar) Nolu Hat', 'Zafertepe Son Durak-İmam Gazali Caddesi-Şeyh Edebali Caddesi-Selahattin Eyyubi Caddesi- Zafer Caddesi-Dr.Sadık Ahmet Caddesi-Kervansaray Sok.-Hacı Mustafa Önsay Cad-Adiller Caddesi-Sadiye sk.-Balaban sk.-Gaziantep sk.-Akşemseddin Köprülü Kavşağı-Yunus Emre Caddesi-Fevzi Çakmak Caddesi-Abdurrahman Karaa Bulvarı-Domaniçler-Atatürk Bulvarı-Laleli Camii-Kütahya Eskişehir Yolu Gidiş İstikameti-Otogar.', 'Otogar-Kütahya Eskişehir Yolu Geliş İstikameti-Atatürk Bulvarı-Laleli Camii-Vazo-Saat Kulesi Önü-Abdurrahman Karaa Bulvarı-Fevzi Çakmak Caddesi-Yunus Emre Caddesi-Akşemseddin Köprülü Kavşağı-Gaziantep caddesi-Balaban sk.-Sadiye sk.-Adiller Caddesi-Hacı Mustafa Önsay Cad.-Kervansaray Sok.-Dr.Sadık Ahmet Caddesi-Zafer Caddesi-Selahattin Eyyubi Caddesi-Şeyh Edebali Caddesi-İmam Gazali Cad.-Zafertepe Son Durak\n'),
(26, '27', '27 (Zafertepe-Otogar) Nolu Hat', '(Ağaçköy-Okul-Olcak Cad.-16. Sok.-12. Sok-Okul-Siner Mah.)-Zafertepe- İmam Gazali Cad.-KYK-Göçmen Evleri-Mahir Ablum Cad.-Sosyal Konutlar-Kent Hastanesi- Dumlupınar Bul.-Fatih Sultan Mehmet Bul.-Subay Lojmanları-Belediye Önü-Atatürk Bulv.-Laleli Camii-Eskişehir Yolu- Ototerminal', 'Ototerminal- Eskişehir Yolu- LaleliCamii-  Atataürk Bulv.- Vazo- Saat Kulesi Önü – Belediye Önü.- Fatih Sultan Mehmet Bul- Subay Lojmanları- Kent Hastanesi- Sosyal Konutlar- Mahir Ablum Cad.- Göçmen Evleri- KYK- İmam Gazali Cad.- Zafertepe--(Siner Mah-Ağaçköy-Okul-Olcak Cad.- 16.Sok.-12.Sok-Okul)');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sokak-hayvanlari`
--

CREATE TABLE `sokak-hayvanlari` (
  `id` int NOT NULL,
  `kupe_no` varchar(25) COLLATE utf8mb4_unicode_ci NOT NULL,
  `isim` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `yas` int NOT NULL,
  `foto_url` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sahip_tc` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'yok'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `sokak-hayvanlari`
--

INSERT INTO `sokak-hayvanlari` (`id`, `kupe_no`, `isim`, `yas`, `foto_url`, `sahip_tc`) VALUES
(15, '403', 'Kucuk Kopek', 1, 'https://www.manzara.gen.tr/w1/K%C3%BC%C3%A7%C3%BCk-%C5%9Firin-k%C3%B6pek.jpg', 'yok'),
(22, '5313', 'Tekir Kedi', 1, 'https://i3.posta.com.tr/i/posta/75/750x0/6196163445d2a07ffcb006f9', 'yok'),
(23, '5313', 'Papagan', 1, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4w_QJCfV_pBAgTSLEfoJRXqNouyI4GInWrw&usqp=CAU', 'yok'),
(24, '5334', 'Hamster', 1, 'https://www.petihtiyac.com/Data/Blog/1/145.jpg', 'yok');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users_table`
--

CREATE TABLE `users_table` (
  `id` int NOT NULL,
  `TC` varchar(11) NOT NULL,
  `tam_ad` varchar(50) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(50) NOT NULL,
  `vergi_no` varchar(11) NOT NULL,
  `cep` varchar(15) NOT NULL,
  `borc_miktari` int NOT NULL DEFAULT '0',
  `son_odeme` varchar(40) NOT NULL,
  `son_odeme_miktari` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Tablo döküm verisi `users_table`
--

INSERT INTO `users_table` (`id`, `TC`, `tam_ad`, `username`, `password`, `vergi_no`, `cep`, `borc_miktari`, `son_odeme`, `son_odeme_miktari`) VALUES
(83, '20938494322', 'Murat Sari', 'murat', '1', 'A4J202J3', '+905439032192', 1057615, '28.12.2022 18:59:05', 5),
(84, '32498423465', 'Nihat Aliyev', 'nihatxp', '42', '543NU89X23', '+905432154321', 90, '0000-00-00 00:00:00', 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `vergitablosu`
--

CREATE TABLE `vergitablosu` (
  `TC` varchar(12) NOT NULL,
  `vergi_no` varchar(25) NOT NULL,
  `borcmiktari` int NOT NULL,
  `vergituru` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Tablo döküm verisi `vergitablosu`
--

INSERT INTO `vergitablosu` (`TC`, `vergi_no`, `borcmiktari`, `vergituru`) VALUES
('11238293832', '3nj38hb3d', 0, 'Emlak Vergisi');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `admins_table`
--
ALTER TABLE `admins_table`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `cozum_masasi_basvurusu`
--
ALTER TABLE `cozum_masasi_basvurusu`
  ADD PRIMARY KEY (`basvuru_id`);

--
-- Tablo için indeksler `kameralar`
--
ALTER TABLE `kameralar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `otobus_bilgileri`
--
ALTER TABLE `otobus_bilgileri`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sokak-hayvanlari`
--
ALTER TABLE `sokak-hayvanlari`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `users_table`
--
ALTER TABLE `users_table`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `TC` (`TC`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Tablo için indeksler `vergitablosu`
--
ALTER TABLE `vergitablosu`
  ADD PRIMARY KEY (`TC`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `admins_table`
--
ALTER TABLE `admins_table`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `cozum_masasi_basvurusu`
--
ALTER TABLE `cozum_masasi_basvurusu`
  MODIFY `basvuru_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- Tablo için AUTO_INCREMENT değeri `kameralar`
--
ALTER TABLE `kameralar`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `otobus_bilgileri`
--
ALTER TABLE `otobus_bilgileri`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- Tablo için AUTO_INCREMENT değeri `sokak-hayvanlari`
--
ALTER TABLE `sokak-hayvanlari`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- Tablo için AUTO_INCREMENT değeri `users_table`
--
ALTER TABLE `users_table`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=96;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

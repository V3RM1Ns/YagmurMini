Restoran Sifariş İdarəetmə Sistemi (ORM) Konsol Tətbiqi
Bu, restoran mühitində menyu elementlərini, sifarişləri və masaları idarə etmək üçün nəzərdə tutulmuş sadə, lakin effektiv konsol əsaslı bir tətbiqdir. Entity Framework Core-dan istifadə edərək verilənlərin saxlanmasını və idarə olunmasını asanlaşdırır.

🌟 Əsas Xüsusiyyətlər
Tətbiq istifadəçilərə aşağıdakı əsas funksionallığı təklif edir:

🍽️ Menyu Elementləri Əməliyyatları

Əlavə Et: Menyuya yeni yemək və içkilər əlavə edin (ad, qiymət, kateqoriya ilə).

Redaktə Et: Mövcud menyu elementlərinin detallarını (ad, qiymət, kateqoriya) yeniləyin.

Sil: Artıq təklif olunmayan menyu elementlərini sistemdən çıxarın.

Göstər: Bütün menyu elementlərini, kateqoriyaya görə, qiymət aralığına görə göstərin və ya adına görə axtarın.

📝 Sifariş Əməliyyatları

Yeni Sifariş Yarat: Birdən çox menyu elementi və onların miqdarını seçməklə yeni sifarişlər daxil edin. Sifarişlər masalara təyin oluna bilər və ya paket servis kimi qeyd edilə bilər.

Ləğv Et: Yanlış və ya ləğv edilmiş sifarişləri sistemdən silin.

İdarə Et: Bütün sifarişləri göstərin, tarixə, məbləğə görə filtrləyin və ya sifariş ID-sinə görə ətraflı məlumat əldə edin.

🛋️ Masa Əməliyyatları

Gələcək İnkişaf: Bu bölmə hazırda aktiv deyil və gələcək versiyalarda masaların idarə edilməsi (status, tutum və s.) üçün genişləndiriləcək.

🛠️ İstifadə Olunan Texnologiyalar
C#: Tətbiqin əsas proqramlaşdırma dili.

.NET: Konsol tətbiqini qurmaq üçün istifadə olunan güclü freymvork.

Microsoft.EntityFrameworkCore: Verilənlər bazası ilə rahat və obyekt-yönümlü qarşılıqlı əlaqə üçün ORM freymvorku.

SQLite (ehtimal ki): Yüngül, fayl əsaslı verilənlər bazası həlli. (AppDbContext konfiqurasiyasına əsasən ehtimal edilir.)

🚀 Quraşdırma və İşə Salma
Tətbiqi lokal maşınınızda işə salmaq üçün aşağıdakı addımları izləyin:

Depositoriyanı Klonlayın:

Bash
git clone [repo-ünvanı]
cd [repo-qovluğu]
Qeyd: Əgər layihəni klonlamırsınızsa, bütün əlaqədar faylların (Entitylər, DTO-lar, Servislər, Contextlər) düzgün qovluq strukturunda olduğundan əmin olun.

NuGet Paketlərini Bərpa Edin:

Bash
dotnet restore
Bu əmr bütün lazımi paketləri (məsələn, Entity Framework Core provayderləri) endirəcək.

Verilənlər Bazası Miqrasiyalarını Tətbiq Edin (əgər mövcuddursa):

Bash
dotnet ef database update
Bu, verilənlər bazası sxeminizi yaradacaq və ya yeniləyəcək.
Qeyd: dotnet ef əmrlərini işə salmaq üçün Microsoft.EntityFrameworkCore.Tools paketinin qlobal olaraq və ya layihəyə DotNetCliToolReference kimi əlavə edildiyindən əmin olun.

Tətbiqi Çalışdırın:

Bash
dotnet run
Tətbiq konsol pəncərəsində işə düşəcək.

📁 Layihə Strukturu
Bu layihə, kodun oxunaqlılığını və baxımını təmin etmək üçün qatmanlı arxitekturaya riayət edir:

Orm.Core.Entities: Verilənlər bazasındakı cədvəllərə uyğun gələn əsas varlıq sinifləri (məsələn, MenuItem, Order, Table).

Orm.BL.Dtos: Verilənlərin tətbiqin qatları arasında ötürülməsi üçün istifadə olunan Data Transfer Obyektləri (DTOs) (məsələn, MenuItemCreateDto, OrderReturnDto).

Orm.BL.Services.Interfaces: Biznes məntiq xidmətləri üçün müqavilələri (interfeysləri) müəyyən edir (məsələn, IMenuItemService).

Orm.BL.Services.Concretes: Yuxarıdakı interfeyslərin konkret tətbiqlərini ehtiva edir, iş məntiqini və verilənlər bazası əməliyyatlarını idarə edir.

Orm.DAL.DataStorage.Contexts: Entity Framework Core istifadə edərək verilənlər bazası ilə əlaqəni quran AppDbContext sinfini ehtiva edir.

Program.cs: Tətbiqin giriş nöqtəsi olub, istifadəçi qarşılıqlı əlaqəsini təmin edir və biznes məntiqini təşkil edir.

📈 Gələcək Təkmilləşdirmələr
Masaların idarə edilməsi (status, tutum və s.) üçün HandleTableOperations metodunun tam tətbiqi.

Daha möhkəm giriş yoxlaması və istifadəçi bildirişləri.

Genişləndirilmiş istifadəçi autentifikasiyası və icazə sistemi.

Daha yaxşı istifadəçi təcrübəsi üçün qrafik interfeysə keçid (məsələn, WPF, ASP.NET Core Blazor).

Satış hesabatları, populyar məhsullar və digər analitik funksiyaların əlavə edilməsi.

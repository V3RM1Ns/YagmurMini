Restoran Sifariş İdarəetmə Sistemi (ORM) Konsol Tətbiqi
Bu, restoran mühitində menyu elementlərini, sifarişləri və masaları idarə etmək üçün nəzərdə tutulmuş konsol əsaslı bir tətbiqdir. Verilənlərin saxlanması üçün Entity Framework Core-dan istifadə edərək, verilənlər bazası ilə möhkəm qarşılıqlı əlaqə təmin edir.

Xüsusiyyətlər
Tətbiq aşağıdakı funksionallığı təklif edir:

Menyu Elementləri Əməliyyatları

Yeni Menyu Elementi Əlavə Et: Menyuya ad, qiymət və kateqoriya ilə yeni yeməklər və ya içkilər əlavə edin.

Mövcud Menyu Elementini Redaktə Et: Mövcud menyu elementinin təfərrüatlarını (ad, qiymət, kateqoriya) yeniləyin.

Menyu Elementini Sil: Sistemdən bir menyu elementini silin.

Bütün Menyu Elementlərini Göstər: Bütün mövcud menyu elementlərinin ətraflı siyahısını göstərin.

Kateqoriyaya Görə Menyu Elementlərini Göstər: Menyu elementlərini kateqoriyalarına görə filtrləyin və göstərin (məsələn, Qəlyanaltılar, Əsas yeməklər, İçkilər).

Qiymət Aralığına Görə Menyu Elementlərini Göstər: Müəyyən bir qiymət aralığındakı menyu elementlərini tapın.

Adına Görə Menyu Elementlərini Axtar: Menyu elementlərini adlarındakı bir açar sözdən istifadə edərək axtarın.

Sifariş Əməliyyatları

Yeni Sifariş Əlavə Et: Birdən çox menyu elementi və miqdar seçiminə imkan verən yeni bir müştəri sifarişi yaradın. Sifarişlər müəyyən bir masaya təyin edilə bilər və ya paket servis kimi qeyd oluna bilər.

Sifarişi Ləğv Et: Sistemdən mövcud bir sifarişi silin.

Bütün Sifarişləri Göstər: Bütün qeydə alınmış sifarişlərin siyahısını göstərin.

Tarix Aralığına Görə Sifarişləri Göstər: Müəyyən bir tarix aralığında verilən sifarişləri filtrləyin və göstərin.

Məbləğ Aralığına Görə Sifarişləri Göstər: Verilmiş bir aralıqdakı ümumi məbləği olan sifarişləri tapın.

Müəyyən Bir Tarixdəki Sifarişləri Göstər: Müəyyən bir tarixdə verilən bütün sifarişləri göstərin.

ID-yə Görə Sifariş Təfərrüatlarını Göstər: Müəyyən bir sifariş haqqında, sifariş edilmiş bütün elementlər daxil olmaqla ətraflı məlumat alın.

Masa Əməliyyatları

Tezliklə Gələcək: Əsas menyu "Masalar üzrə əməliyyatlar aparın" seçimini əhatə etsə də, təqdim olunan kod parçasında HandleTableOperations metodunun tətbiqi yoxdur. Bu funksionallıq gələcək inkişaf üçün nəzərdə tutulub.

İstifadə Olunan Texnologiyalar
C#: Tətbiqin əsas proqramlaşdırma dili.

.NET: Konsol tətbiqini qurmaq üçün istifadə olunan freymvork.

Microsoft.EntityFrameworkCore: Verilənlər bazası ilə qarşılıqlı əlaqəni sadələşdirən bir ORM freymvorku.

SQLite (Ehtimal ki): AppDbContext-ə əsaslanaraq, SQLite-ın yüngül, fayl əsaslı bir verilənlər bazası həlli təklif edən verilənlər bazası provayderi kimi istifadə olunduğu ehtimal olunur. (Bu fərziyyə, AppDbContext-in tipik olaraq müəyyən bir provayderlə konfiqurasiya edilməsi səbəbindən irəli sürülür).

Quraşdırma və Yükləmə
Bu tətbiqi işə salmaq üçün aşağıdakı addımları izləyin:

Depositoriyanı Klonlayın (və ya kodu kopyalayın):
Əgər bu kod daha böyük bir layihənin hissəsidirsə, bütün depositoriyanı klonlayın. Əks halda, bütün əlaqədar faylların (DTO-lar, servislər, kontekstlər, varlıqlar) düzgün layihə strukturunda olduğundan əmin olun.

NuGet Paketlərini Bərpa Edin:
Terminalda layihə qovluğuna keçin və aşağıdakını işə salın:

Bash
dotnet restore
Bu, Microsoft.EntityFrameworkCore və onun xüsusi verilənlər bazası provayderi (məsələn, Microsoft.EntityFrameworkCore.Sqlite) daxil olmaqla bütün lazımi NuGet paketlərini endirəcək.

Verilənlər Bazası Miqrasiyaları (əgər tətbiq olunursa):
Əgər AppDbContext-iniz və Entity Framework Core qurulumunuz miqrasiyaları əhatə edirsə, verilənlər bazası sxeminizi yaratmaq və ya yeniləmək üçün onları tətbiq etməlisiniz.

Bash
dotnet ef database update
Qeyd: dotnet ef əmrlərini işə salmaq üçün Microsoft.EntityFrameworkCore.Tools paketinin DotNetCliToolReference olaraq və ya qlobal olaraq quraşdırıldığından əmin olun.

Tətbiqi Çalışdırın:
Tətbiqi birbaşa IDE-dən (Visual Studio kimi) və ya terminaldan işə sala bilərsiniz:

Bash
dotnet run
Necə İstifadə Etməli
Tətbiq işə düşəndə sizə əsas menyu təqdim olunacaq:

╔══════════════════════════════════════════╗
║               ƏSAS MENYU                 ║
╠══════════════════════════════════════════╣
║ 1. Menyu Elementləri üzrə əməliyyatlar    ║
║ 2. Sifarişlər üzrə əməliyyatlar           ║
║ 3. Masalar üzrə əməliyyatlar              ║
║ 0. Sistemdən çıxış                        ║
╚══════════════════════════════════════════╝
Müvafiq nömrəni daxil edərək (1, 2, 3 və ya 0) və Enter düyməsini sıxaraq bir seçim edin.

Hər bir əməliyyat üçün ekrandakı təlimatlara əməl edin. Tətbiq sizə ID-lər, adlar, qiymətlər, miqdarlar və tarixlər kimi zəruri məlumatları daxil etməkdə bələdçilik edəcək.

Yanlış məlumat daxil etdiyiniz təqdirdə sizə bələdçilik etmək üçün səhv idarəetməsi mövcuddur.

Əksər əməliyyatlardan sonra alt-menyaya qayıtmaq üçün istənilən düyməni basın.

Əvvəlki menyuya qayıtmaq üçün istənilən alt-menyuya "0" daxil edin.

Layihə Strukturu (Fərz Edilən)
using bəyanatlarına əsasən, layihə böyük ehtimalla çoxqatlı arxitekturaya malikdir:

Orm.Core.Entities: Əsas varlıq siniflərini (məsələn, MenuItem, Order, OrderItem, Table, Category) ehtiva edir.

Orm.BL.Dtos: Müxtəlif varlıqlar üçün məlumat girişi və çıxışı üçün istifadə olunan Data Transfer Obyektlərini (DTOs) saxlayır (məsələn, MenuItemCreateDto, OrderReturnDto).

Orm.BL.Services.Interfaces: Biznes məntiq xidmətləri üçün interfeysləri müəyyən edir (məsələn, IMenuItemService, IOrderService, ITableService).

Orm.BL.Services.Concretes: Biznes məntiq xidmətlərinin konkret tətbiqlərini təmin edir.

Orm.DAL.DataStorage.Contexts: Entity Framework Core istifadə edərək verilənlər bazası ilə qarşılıqlı əlaqə qurmaqdan məsul olan AppDbContext sinfini ehtiva edir.

Program.cs: Konsol tətbiqinin giriş nöqtəsi olub, istifadəçi qarşılıqlı əlaqəsini idarə edir və biznes məntiq xidmətlərinə çağırışları təşkil edir.

Gələcək Təkmilləşdirmələr
Masaların idarə edilməsinə imkan vermək üçün HandleTableOperations metodunu tətbiq edin.

Daha möhkəm giriş yoxlaması və səhv idarəetməsi əlavə edin.

İstifadəçi identifikasiyası və icazələri tətbiq edin.

Daha yaxşı istifadəçi təcrübəsi üçün daha qabaqcıl bir UI freymvorku (məsələn, WPF, ASP.NET Core MVC/Blazor) nəzərdən keçirin.

Satışlar, populyar elementlər və s. üçün hesabat funksiyaları əlavə edin.

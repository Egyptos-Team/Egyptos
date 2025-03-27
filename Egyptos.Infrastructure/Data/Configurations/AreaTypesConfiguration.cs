using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaTypesConfiguration : IEntityTypeConfiguration<AreaType>
{
    public void Configure(EntityTypeBuilder<AreaType> builder)
    {
        var areaTypes = new List<AreaType>
        {
            new AreaType // 30
            {
                Id=1,
                Name="Fixed artifacts"
            },
            new AreaType // 25
            {
                Id=2,
                Name="Archaeological sites"
            },
            new AreaType // 8
            {
                Id=3,
                Name="Sunken artifacts"
            },
            new AreaType // 10
            {
                Id=4,
                Name="Safari"
            },
            new AreaType // 10 D
            {
                Id=5,
                Name="Marine and Nile"
            },
            new AreaType // 10 D
            {
                Id=6,
                Name="Mountainous"
            },
            new AreaType // 10 D
            {
                Id=7,
                Name="Rural and natural"
            },
            new AreaType // Alaa Fayez & Nayira & Rodina 
            {
                Id=8,
                Name="Museums"
            }
            /*
                المتحف المصري
                المتحف القومي للحضارة المصرية
                متحف الفن الإسلامي
                المتحف القبطي
                متحف جاير أندرسون (بيت الكريتلية)
                متحف قصر عابدين
                متحف المركبات الملكية
                متحف أم كلثوم
                متحف الشرطة القومي
                متحف النسيج المصري
                متحف ركن فاروق
                متحف قصر الأمير محمد علي
                متحف الشمع
                المتحف الجيولوجي المصري
                متحف الفن المصري الحديث
                متحف قصر المنيل
                متحف البريد المصري
                متحف الطفل
                متحف الشاعر أحمد شوقي
                متحف طه حسين
                متحف طنطا
                متحف دمنهور
                متحف الشرقية
                متحف كفر الشيخ
                متحف سوهاج القومي
                متحف قنا
                متحف بني سويف
                متحف الواحات البحرية
                متحف العريش
            ----------------------------------------------------
                المتحف المصري الكبير
                متحف مركب الشمس
                متحف ميت رهينة المفتوح
                المتحف اليوناني الروماني
                متحف الإسكندرية القومي
                متحف المجوهرات الملكية
                متحف الأحياء المائية
                متحف الأقصر
                متحف التحنيط
                متحف النوبة
                متحف أسوان
                متحف السويس القومي
                متحف بورسعيد الحربي
                متحف دار ابن لقمان
                متحف كوم أوشيم
                متحف شرم الشيخ
                متحف الغردقة
                متحف الخارجة
                متحف دمياط
                متحف ملوي
            --------------------------------------------
            */
        };
        builder.HasData();
    }
}


# سامانه آموزش‌یار

این پروژه یک برنامه ویندوزی برای مدیریت اطلاعات دانشجویان است که به شما امکان ثبت، ویرایش و حذف اطلاعات دانشجویان را می‌دهد. همچنین این برنامه دارای قابلیت بارگذاری و ذخیره‌سازی داده‌ها در فایل‌های خارجی است.

## فهرست مطالب

- [درباره پروژه](#درباره-پروژه)
- [ویژگی‌ها](#ویژگی‌ها)
- [نصب و راه‌اندازی](#نصب-و-راه‌اندازی)
- [نحوه استفاده](#نحوه-استفاده)
- [مشارکت در توسعه](#مشارکت-در-توسعه)
- [لایسنس](#لایسنس)

## درباره پروژه

این برنامه جهت مدیریت اطلاعات دانشجویان طراحی شده و به کاربر امکان می‌دهد تا داده‌های دانشجویان شامل نام، نام خانوادگی، شماره دانشجویی، سن، رشته تحصیلی و جنسیت را مدیریت کند.

## ویژگی‌ها

- **ثبت اطلاعات دانشجو**: با وارد کردن اطلاعات دانشجو و فشردن دکمه "ثبت"، اطلاعات وارد شده ذخیره می‌شود.
- **ویرایش اطلاعات دانشجو**: با انتخاب دانشجو از لیست ویرایش و تغییر اطلاعات آن امکان‌پذیر است.
- **حذف اطلاعات دانشجو**: قابلیت حذف اطلاعات دانشجو از سیستم.
- **بارگذاری و ذخیره‌سازی داده‌ها**: امکان بارگذاری و ذخیره‌سازی داده‌ها از/به فایل‌ها.
- **رابط کاربری ساده و فارسی**: تمامی منوها و فرم‌ها به زبان فارسی بوده و استفاده از آن آسان است.

## نصب و راه‌اندازی

برای راه‌اندازی این پروژه به ابزارهای زیر نیاز دارید:

1. **کلون کردن مخزن**:
   ```bash
   git clone https://github.com/username/SampleCodeWithSplashScreen.git
   ```

2. **باز کردن پروژه در ویژوال استودیو**: پس از کلون کردن مخزن، پروژه را در محیط **Visual Studio** باز کنید.

3. **ساخت و اجرای پروژه**:
   از طریق ویژوال استودیو، پروژه را بیلد کرده و اجرا کنید:
   ```bash
   dotnet build
   dotnet run
   ```

## نحوه استفاده

1. **ثبت اطلاعات دانشجو**:
   - ابتدا نام، نام خانوادگی، شماره دانشجویی، سن، رشته و جنسیت دانشجو را وارد کنید.
   - سپس روی دکمه "ثبت" کلیک کنید تا اطلاعات ذخیره شود.

2. **ویرایش اطلاعات دانشجو**:
   - دانشجویی را از لیست انتخاب کنید، اطلاعات مورد نظر را تغییر دهید و روی دکمه "ویرایش" کلیک کنید.

3. **حذف دانشجو**:
   - با انتخاب دانشجو و فشردن دکمه "حذف"، اطلاعات آن دانشجو از سیستم حذف خواهد شد.

4. **ذخیره و بارگذاری اطلاعات**:
   - از طریق منوی "فایل" گزینه‌های "ذخیره" و "بارگذاری" برای مدیریت فایل‌ها در دسترس است.

## مشارکت در توسعه

در صورتی که علاقه‌مند به مشارکت در توسعه این پروژه هستید:

1. مخزن را fork کنید.
2. یک شاخه جدید برای تغییرات خود بسازید:
   ```bash
   git checkout -b feature/your-feature
   ```
3. تغییرات خود را اعمال کرده و commit کنید:
   ```bash
   git commit -m 'توضیح تغییرات'
   ```
4. تغییرات را به مخزن خود push کنید:
   ```bash
   git push origin feature/your-feature
   ```
5. یک Pull Request باز کنید.

## لایسنس

این پروژه تحت لایسنس MIT منتشر شده است. برای اطلاعات بیشتر فایل [LICENSE](LICENSE) را مطالعه کنید.

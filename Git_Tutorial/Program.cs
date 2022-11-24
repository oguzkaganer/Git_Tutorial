﻿namespace Git_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            //  - Versiyon kontrolü --> git --version
            //
            //  - Versiyon güncelleme --> git update-git-for-windows
            //
            //  - Config ayarlarını görüntüleme --> git config --list
            //     - Bu komutu kullandıktan sonra çıkış yapmak için 'Q' tuşuna basabilirsiniz.
            //
            //  - Uzak repotan klonlamak için --> git clone https://github.com/oguzkaganer/Git_Tutorial.git
            //     - Hangi dosya üzerinde komut yazılıyorsa o dosyaya indirir.




            //  - Git repo oluşturmak için --> git init
            //
            //  - Username ayarı yapmak için --> git config --global user.name "İsim Soyisim"
            //
            //  - Usermail ayarı yapmak için --> git config --global user.email "user@gmail.com"
            //
            //  - Bütün değişikleri Stage'e alma işlemi --> git add .
            //
            //  - Stage'den geri alma işlemi --> git reset
            //
            //  - Stage'dekileri commitleme --> git commit -m "commit mesajı"  OR  git commit -m mesaj (tek kelimelik mesaj olacaksa)
            //
            //  - İstenilen bir commite geri dönme --> git reset --hard <Commit ID>  ÖRNEK : git reset --hard 184a7b5e
            //     - Eğer bir düzenleme yapıp commit işlemi yaptıysanız ancak henüz push yapmadıysanız ve son commitinizi silmek istiyorsanız
            //       bunun için bu komutu kullanabilirsiniz. commit IDsine bir önceki commitin ıd sini yazarak.
            //     - Diğer durumda yani commit uzak repoya atımışsa istenilen geçmiş commite dönülebilir ancak ancak commitler uzak repodan silinmez.
            //
            //  - Commitleri uzak repoya atma --> git push origin master
            //
            //  - Uzak repodan değişiklikleri çekme --> git pull
            //
            //  - Branch


        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEnhancer
{
    class ToS
    {
        public static Dictionary<string, string> Languages = new Dictionary<string, string>()
        {
            { "English", "en" },
            { "Türkçe", "tr" },
            { "Español", "es" },
            { "Tiếng Việt", "vi" },
            { "中文", "zh" },
            { "Čeština", "cs" },
            { "Polski", "pl" },
            { "Nederlands", "nl" },
            { "Lietuvių Kalba", "lt" },
            { "Українська", "uk" },
            { "Norsk", "no" },
            { "Français", "fr" },
            { "Latviešu Valoda", "lv" },
            { "Shqip", "sq" },
            { "Dansk", "da" },
            { "Bahasa Indonesia", "in" },
            { "Deutsch", "de" },
            { "Русский язык", "ru" },
            { "Suomi", "fi" },
            { "Português", "pt" },
            { "Svenska", "sv" },
            { "Pirate", "pirate" }
        };

        public static string GetTermsOfService(string language)
        {
            switch (language.ToLower())
            {

                case "tr":
                    /*Turkish*/
                    return "Devam etmeden önce lütfen aşağıdaki şartları kabul edin:\n\n"

                        + "Bu program, hesabınızın VAC ban yemesine sebep olmayacaktır. Ancak hesabınızın herhangi bir şekilde "
                        + "VAC ban yemesi durumunda herhangi bir sorumluluk kabul etmiyorum. Umarım hesabınızda "
                        + "hile kullanıp banlandıktan sonra bu programı suçlamayacak kadar akıllısınızdır.\n\n"

                        + "Bunu anlıyor ve kabul ediyor musunuz?\n"
                        + "HAYIR'a basmak programı kapatacaktır.\n\n"
                        + "Translation by: Alperen";

                case "es":
                    /*Spanish*/
                    return "Usted debe aceptar los siguientes condiciones antes de continuar:\n\n"

                        + "Este programa no impondrá el bloqueo VAC a su cuenta. Sin embargo, se asumirá la responsabilidad, "
                        + "si por alguna razón su cuenta se impuso el bloqueo. Espero que seas lo suficientemente inteligente "
                        + "y no hacer trampas en su cuenta y, a continuación, echarle la culpa al programa ni a mí.\n\n"

                        + "¿Usted entiende y está de acuerdo con eso?\n"
                        + "Pulse 'No' para salir del programa.\n\n"
                        + "Translation by: Justino";

                case "vi":
                    /*Vietnamese*/
                    return "Trước khi tiếp tục, bạn phải đồng ý những điều khoản dưới đây:\n\n"

                        + "Phần mềm này sẽ không làm tài khoản của bạn bị VAC ban. Tuy nhiên, tôi sẽ không chịu "
                        + "trách nhiệm cho bất cứ trường hợp nào khiến tài khoản của bạn bị ban. Đừng đổ lỗi cho tôi hay "
                        + "phần mềm này nếu chính bạn là người gian lận khiến tài khoản của bạn bị khóa.\n\n"

                        + "Bạn đã hiểu rõ và chấp nhận điều trên chưa?\n"
                        + "Ấn vào nút 'No' để thoát khỏi chương trình.\n\n"
                        + "Translation by: Truong";

                case "zh":
                    /*Chinese*/
                    return "在继续之前，您请同意以下条款：\n\n"

                        + "此程序不会导致您的帐户被VAC Ban，"
                        + "但是如果您的账号被VAC Ban 作者不会承担任何责任！"
                        + "我希望你们不要在游戏中作弊然后怪罪于我或软件。\n\n"

                        + "请问您明白并同意这条款吗？\n"
                        + "点击“不同意”将会退出软件。\n\n"
                        + "Translation by: 小龍";

                case "cs":
                    /*Czech*/
                    return "Prosím, souhlaste s následujícími podmínkami, než budete pokračovat:\n\n"

                        + "Tento program nezpůsobí VAC ban. Nicméně, nenesu žádnou odpovědnost "
                        + "pokud z nějakého důvodu váš účet dostane VAC ban. Doufám, že jste chytří "
                        + "dost na to, aby jste nehackovali na vašem účtu a pak mě za to budete obviňovali.\n\n"

                        + "Rozumíte a souhlasíte s těmito podmínkami?\n"
                        + "Stisknutí 'No' ukončí program.\n\n"
                        + "Translation by: Boris";

                case "pl":
                    /*Polish*/
                    return "Przeczytaj poniższą informację przed kontynuacją:\n\n"

                        + "Ten program nie sprawi, że Twoje konto dostanie VAC'a. Nie odpowiadam, za zbanowane konta, bo "
                        + "myślę że jesteś na tyle mądry, że nie cheatujesz. Jeżeli dostaniesz VAC'a a cheatowałeś, nie "
                        + "obwiniaj mnie bądź tego programu.\n\n"

                        + "Zrozumiałeś i akceptujesz to?\n"
                        + "Klikając 'No' zamkniesz program.\n\n"
                        + "Translation by: Ryszard";

                case "nl":
                    /*Dutch*/
                    return "Ga akkoord met de volgende voorwaarden voordat u verder gaat:\n\n"

                        + "Dit programma zal niet leiden tot een VAC BAN. Echter, neem ik geen verantwoordelijkheid "
                        + "als er om welke reden dan ook uw account verbannen wordt. Ik hoop dat u slim genoeg "
                        + "bent om niet te gaan cheaten op uw account en daarna de schuld op het programma schuift.\n\n"

                        + "Begrijpt u dit en gaat u akkoord?\n"
                        + "Op 'No' drukken zorgt ervoor dat het programma afsluit.\n\n"
                        + "Translation by: Merle";

                case "lt":
                    /*Lithuanian*/
                    return "Prašau sutikti su salygomis prieš naudojant programą:\n\n"

                        + "Ši programa niekaip nepakenks jūsų Steam Accountui, dėl šios programos jūs negausite VAC. "
                        + "Bet vis dėl to aš neprisiimu jokios atsakomybės jei jūsų Accountas bus užbanintas. "
                        + "Aš tikiuosi Jūs esate pakankamai gudrus nenaudoti kitu programų, o poto kaltinti šia programą.\n\n"

                        + "Ar Jūs supratote ir sutinkate su salygomis?\n"
                        + "Paspaudus 'No' išjunksite programą.\n\n"
                        + "Translation by: Harald";

                case "uk":
                    /*Ukrainian*/
                    return "Будь ласка, прийміть наступні умови угоди, перш ніж продовжити:\n\n"

                        + "Використання даної програми не призведе до VAC бану вашого акаунта. У будь-якому випадку, автор не несе за "
                        + "собою відповідальності за будь-які блокування, які ви можете отримати. Ми сподіваємося, що ви достатньо "
                        + "розумні, щоб не використовувати чіт-програми на своєму акаунті після цього звинувачувати "
                        + "в причини блокування дану програму і автора.\n\n"

                        + "Чи згодні ви з даними умовами?\n"
                        + "Відмова від умов угоди призведе до скасування установки.\n\n"
                        + "Translation by: Володя";

                case "no":
                    /*Norwegian*/
                    return "Vennligst godta følgende vilkår før du fortsetter:\n\n"

                        + "Dette programmet vil ikke føre til at kontoen din får VAC ban. Men jeg tar ikke ansvar "
                        + "vis kontoen din blir VAC bannet på noen måter. Jeg håper du er smart nok til å ikke "
                        + "jukse på kontoen din, og så skylde på programmet eller meg.\n\n"

                        + "Forstår du og er enig i dette?\n"
                        + "Ved å trykke 'No' vil avslutte programmet.\n\n"
                        + "Translation by: Lars";

                case "fr":
                    /*French*/
                    return "Sil vous plaît acceptez les conditions suivante avant de continuer:\n\n"

                        + "Ce programme ne causera pas de bannissement vac sur votre compte. Je ne prends aucune "
                        + "si pour n'importe quel raison vous vous faite bannir. J'espère que vous êtes assez intelligent "
                        + "pour ne pas tricher sur votre compte. Et de rejeter la faute sur le logiciel ou moi.\n\n"

                        + "Comprenez vous et accepter ceci?\n"
                        + "Appuyer sur 'No' fermera le programme.\n\n"
                        + "Translation by: Colan";

                case "lv":
                    /*Latvian, Lettish*/
                    return "Lūdzu piekrītiet šādiem noteikumiem pirms turpināt:\n\n"

                        + "Šī programma neizraisīs VAC banu. Tomēr es neuzņemos atbildību, ja kāda iemesla "
                        + "dēļ jūsu konts tiek nobanots. Es ceru ,ka esat pietiekami gudrs lai nekrāptos "
                        + "uz sava konta un vainot šo programmu vai mani.\n\n"

                        + "Vai jūs saprotiet un piekrītiet?\n"
                        + "Spiežot 'No' jūs iziesiet no programmas.\n\n"
                        + "Translation by: Matthias";

                case "sq":
                    /*Albanian*/
                    return "Ju lutem pranoni kushtet e mëposhtme para se te vazhdoni:\n\n"

                        + "Ky program nuk do të shkaktojë nje VAC Ban në llogarinë tuaj. Megjithatë, unë nuk marrë asnjë "
                        + "përgjegjësi në qoftë se për ndonjë arsye llogaria juaj bllokohet. Unë shpresoj se ju jeni mjaft "
                        + "i zgjuar për të mos perdorur hilera në llogarinë tuaj dhe pastaj të fajësoni këtë program ose mua.\n\n"

                        + "A e kuptoni dhe bini dakord me këtë?\n"
                        + "Shtypja 'No' do të mbyllë programin.\n\n"
                        + "Translation by: Zamira";

                case "da":
                    /*Danish*/
                    return "Venligst accepter de følgende regler, før du forsætter:\n\n"

                        + "Dette program vil ikke påføre din konti et VAC ban. Men, Jeg tager fratager mig "
                        + "ethvert ansvar, hvis din konti bliver VAC banned. Jeg håber du er klog nok til ikke at snyde "
                        + "på din konti, og så derefter påstå at det var programmet eller mig som forårsagede det.\n\n"

                        + "Forstår og accepter du disse forhold?\n"
                        + "Tryk på 'No' vil lukke programmet.\n\n"
                        + "Translation by: Nalren";

                case "in":
                    /*Indonesian*/
                    return "Silakan setuju dengan persyaratan berikut sebelum Anda melanjutkan:\n\n"

                        + "Program ini tidak akan menyebabkan akun Anda untuk mendapatkan VAC ban. Namun Saya tidak "
                        + "bertanggung jawab atas alasan apapun account Anda akan terkena ban. Saya harap Anda cukup cerdas "
                        + "untuk tidak menggunakan cheat pada akun Anda dan kemudian menyalahkan program ini atau saya.\n\n"

                        + "Apakah Anda memahami dan setuju dengan hal ini?\n"
                        + "Menekan 'No' akan keluar dari program.\n\n"
                        + "Translation by: Santi";

                case "de":
                    /*German*/
                    return "Bitte akzeptieren Sie folgende Bedingungen bevor Sie fortfahren:\n\n"

                        + "Durch dieses Programm wird ihr Account nicht VAC gebannt, jedoch übernehme ich keinerlei Verantwortung "
                        + "und/oder Haftung, falls ihr Account doch gebannt werden sollte. Da es sich im Grunde genommen "
                        + "hierbei um cheating handelt und eine sperre erfolgen sollte, beschuldigen sie bitte weder mich, noch das Programm.\n\n"

                        + "Falls Sie diese Bedingungen nicht akzeptieren sollten "
                        + "drücken Sie bitte 'No' und das Programm wird sich automatisch schließen.\n\n"
                        + "Translation by: Henrik";

                case "be":
                case "ru":
                    /*Russian*/
                    return "Пожалуста, примите следующие условия соглашения прежде чем продолжить:\n\n"

                        + "Использование этой программы не приведёт к VAC бану. В любом случае, я не несу "
                        + "ответственности за любые блокировки, которые вы получите. Я надеюсь вы достаточно умны "
                        + "чтобы не использовать читы на своём аккаунте и после этого флеймить на мою программу или меня.\n\n"

                        + "Согласны ли вы с данными условиями?\n"
                        + "Нажатие кнопки 'No' приведёт к выходу из программы.\n\n"
                        + "Translation by: Nikolai";

                case "fi":
                    /*Finnish*/
                    return "Jatkaaksesi, hyväksy seuraavat ehdot:\n\n"

                        + "Tämä ohjelma ei tule aiheuttamaan sinulle VAC bannia. Kuitenkaan, en ota mitään "
                        + "vastuuta jos mistään syystä käyttäjäsi saa bannit. Toivottavasti olet tarpeeksi "
                        + "viisas olemaan käyttämättä huijauskoodeja ja sitten syyttämään tätä ohjelmaa/minua.\n\n"

                        + "Ymmärrätkö ja hyväksytkö nämä ehdot?\n"
                        + "Painamalla 'No' suljet ohjelman.\n\n"
                        + "Translation by: Allan";

                case "pt":
                    /*↓↓↓↓↓↓↓↓↓↓*/
                case "br":
                    /*Portuguese*/
                    return "Por favor concorde com os seguintes termos antes de continuar:\n\n"

                        + "Este programa não vai causar banimento por VAC em sua conta. Porém, eu não vou levar a responsabilidade "
                        + "se por qualquer razão sua conta for banida. Eu espero que você seja inteligente o suficiente "
                        + "para não trapacear na sua conta e depois colocar a culpa no programa ou em mim.\n\n"

                        + "Você entende e concorda com isso?\n"
                        + "Aperte 'No' para sair do programa.\n\n"
                        + "Translation by: Wellington";

                case "sv":
                    /*Swedish*/
                    return "Du måste godkänna följande användarvillkor innan du fortsätter:\n\n"

                        + "Användandet av detta program kommer inte att orsaka ett VAC-ban för ditt account. Jag kommer däremot "
                        + "inte ta ansvar för ditt konto om du av någon anledning blir VAC-Bannad. Jag hoppas att du är smart "
                        + "nog att inte fuska i spel och sedan skylla på detta program eller mig om du blir bannad.\n\n"

                        + "Godkänner du användarvillkoren?\n"
                        + "Om du trycker 'No' så kommer programmet att avslutas.\n\n"
                        + "Translation by: Camilo";

                case "pirate":
                    /*Pirate*/
                    return "Please agree to th' followin' terms before ye continue:\n\n"

                        + "'tis program gunna not cause ye account to get VAC banned. However, I gunna take no responsibility "
                        + "if fer any reason ye account gets banned. I woe ye be smart that be all I can take not to cheat "
                        + "on ye account 'n then blame it on 'tis program or me.\n\n"

                        + "Do ye understand 'n agree to 'tis?\n"
                        + "Pressin' 'No' gunna exit th' program.\n\n"
                        + "Translation by: Crpsem";
                    
                default:
                    /*English*/
                    return "Please agree to the following terms before you continue:\n\n"

                        + "This program will not cause your account to get VAC banned. However, I will take "
                        + "no responsibility if for any reason your account gets banned. I hope you are smart "
                        + "enough not to cheat on your account and then blame it on this program or me.\n\n"

                        + "Do you understand and agree to this?\n"
                        + "Pressing 'No' will exit the program.";
            }
        }
    }
}

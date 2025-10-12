using System;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;
using VatrogasnaSluzba.Forms;

namespace VatrogasnaSluzba.Helpers
{
    using static ControlValidator;
    public static class LiceValidator
    {
        public static bool ValidateLiceForm(
            TextBox txbMatbr, TextBox txbIme, TextBox txbPrezime,
            ComboBox comboPol, TextBox txbAdresa, TextBox txbEmail,
            ComboBox comboPozicija, ComboBox comboStanica)
        {
            if (!IsValidMatBr(txbMatbr, "Unesite validan matični broj.")) return false;
            if (!IsValid(txbIme, "Unesite ime.")) return false;
            if (!IsValid(txbPrezime, "Unesite prezime.")) return false;
            if (!IsValid(comboPol, "Izaberite pol.")) return false;
            if (!IsValid(txbAdresa, "Unesite adresu.")) return false;
            if (!IsValid(txbEmail, "Unesite email adresu.")) return false;
            if (!IsValid(comboPozicija, "Izaberite poziciju.")) return false;
            if (!IsValid(comboStanica, "Izaberite stanicu.")) return false;

            return true;
        }

        public static bool ValidateVatrogasac(ComboBox comboObucenost, TextBox txbSprema, TextBox txbSertifikati)
        {
            if (!IsValid(comboObucenost, "Izaberite nivo obučenosti.")) return false;
            if (!IsValid(txbSprema, "Unesite fizičku spremu.")) return false;
            if (!IsValidInt(txbSertifikati, "Unesite validan broj sertifikata (samo cifre).")) return false;

            return true;
        }

        public static bool ValidateTehnicar(TextBox txbSpecijalizacija)
        {
            return IsValid(txbSpecijalizacija, "Unesite specijalizaciju tehničara.");
        }

        public static bool ValidateDispecer(TextBox txbTipOpreme, TextBox txbBrSmena)
        {
            if (!IsValid(txbTipOpreme, "Unesite tip komunikacione opreme.")) return false;
            if (!IsValidInt(txbBrSmena, "Unesite validan broj smena mesečno (samo cifre).")) return false;

            return true;
        }
    }
}

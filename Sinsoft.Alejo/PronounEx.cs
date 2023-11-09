using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinsoft.Alejo
{
    [Serializable]
    public partial class PronounEx : Pronoun
    {

        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }

        [JsonProperty("possessive_adjective")]
        public string PossessiveAdjective { get; set; }

        [JsonProperty("possessive_pronoun")]
        public string PossessivePronoun { get; set; }

        [JsonProperty("reflexive")]
        public string Reflexive { get; set; }

        [JsonProperty("past_tense")]
        public string PastTense { get; set; }

        [JsonProperty("current_tense")]
        public string CurrentTense { get; set; }

        public static PronounEx AeAer { get { return new PronounEx("aeaer", "Ae/Aer", "Ae", "Aer", "Aers", "Aers", "Aerself", "Was", "Is", false); } }
        public static PronounEx Any { get { return TheyThem; } }
        public static PronounEx EEm { get { return new PronounEx("eem", "E/Em", "E", "Em", "Eir", "Eirs", "Eirself", "Was", "Is", false); } }
        public static PronounEx FaeFaer { get { return new PronounEx("faefaer", "Fae/Faer", "Fae", "Faer", "Faer", "Faers", "Faerself", "Were", "Are", false); } }
        public static PronounEx HeHim { get { return new PronounEx("hehim", "He/Him", "He", "Him", "His", "His", "Himself", "Was", "Is", false); } }
        public static PronounEx HeShe { get { return TheyThem; } }
        public static PronounEx HeThey { get { return TheyThem; } } //Only for legacy support and ease of use interaction. Not in the new API.
        public static PronounEx ItIts { get { return new PronounEx("itits", "It/Its", "It", "It", "Its", "Its", "Itself", "Was", "Is", false); } }
        public static PronounEx Other { get { return TheyThem; } }
        public static PronounEx PerPer { get { return new PronounEx("perper", "Per/Per", "Per", "Per", "Pers", "Pers", "Perself", "Was", "Is", false); } }
        public static PronounEx SheHer { get { return new PronounEx("sheher", "She/Her", "She", "Her", "Hers", "Hers", "Herself", "Was", "Is", false); } }
        public static PronounEx SheThey { get { return TheyThem; } } //Only for legacy support and ease of use interaction. Not in the new API.
        public static PronounEx TheyThem { get { return new PronounEx("theythem", "They/Them", "They", "Them", "Their", "Theirs", "Themself", "Were", "Are", false); } }
        public static PronounEx VeVer { get { return new PronounEx("vever", "Ve/Ver", "Ve", "Ver", "Vis", "Vis", "Verself", "Was", "Is", false); } }
        public static PronounEx XeXem { get { return new PronounEx("xexem", "Xe/Xem", "Xe", "Xem", "Xyr", "Xyrs", "Xemself", "Was", "Is", false); } }
        public static PronounEx ZieHir { get { return new PronounEx("ziehir", "Zie/Hir", "Zie", "Hir", "Hir", "Hirs", "Hirself", "Was", "Is", false); } }

        public static List<PronounEx> Pronouns
        {
            get
            {
                return new List<PronounEx>
                {
                    //There is a programatic way to do this with System.Reflection but it's beyond my ability to understand at the moment.
                    AeAer,
                    Any,
                    EEm,
                    FaeFaer,
                    HeHim,
                    HeShe,
                    HeThey,
                    ItIts,
                    Other,
                    PerPer,
                    SheHer,
                    SheThey,
                    TheyThem,
                    VeVer,
                    XeXem,
                    ZieHir
                };

            }
        }

        public static PronounEx GetPronounExByPronounId(string pronounId)
        {
            foreach (PronounEx pex in Pronouns)
            {
                if (pex.Name == pronounId) { return pex; }
            }

            //If none of the pronouns match, return TheyThem as a catch all.
            return TheyThem;
        }

        public static PronounEx GetPronounExByFriendlyName(string friendlyName)
        {
            foreach (PronounEx pex in Pronouns)
            {
                if (pex.FriendlyName == friendlyName) { return pex; }
            }

            //If none of the pronouns match, return TheyThem as a catch all.
            return TheyThem;
        }

        public PronounEx(string name, string friendlyName, string subject, string @object, string possessiveAdjective, string possessivePronoun, string reflexive, string pastTense, string currentTense, bool singular)
        {
            Name = name;
            FriendlyName = friendlyName;
            Subject = subject;
            Object = @object;
            PossessiveAdjective = possessiveAdjective;
            PossessivePronoun = possessivePronoun;
            Reflexive = reflexive;
            PastTense = pastTense;
            CurrentTense = currentTense;
            Singular = singular;
        }

        public override string ToString()
        {
            return FriendlyName;
        }
    }
}

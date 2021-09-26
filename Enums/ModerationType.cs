using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFiveBlog.Enums
{
    public enum ModerationType
    {
		[Description("Political propagandar")]
        Political,
		[Description("Offensive language")]
		Language,
		[Description("Drug references")]
		Drugs,
		[Description("Threatening content")]
		Threatening,
		[Description("Sexsual content")]
		Sexsual,
		[Description("Hate speech")]
		HateSpeech,
		[Description("Targeted shaming")]
		Shaming
    }
}

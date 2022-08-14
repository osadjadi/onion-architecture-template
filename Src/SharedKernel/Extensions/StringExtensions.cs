using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace SharedKernel.Extensions;

public static class StringExtensions {

	public static string ToPersianNumbers(this string input) {
		if (string.IsNullOrEmpty(input))
			return input;

		var stringBuilder = new StringBuilder(input);
		var mapper = new Dictionary<string, string>()
		{
			{"1", "۱"}, {"2", "۲"}, {"3", "۳"},
			{"4", "۴"}, {"5", "۵"}, {"6", "۶"},
			{"7", "۷"}, {"8", "۸"}, {"9", "۹"},
			{"0", "۰"}
		};

		foreach (var pair in mapper) {
			stringBuilder.Replace(pair.Key, pair.Value);
		}

		return stringBuilder.ToString();
	}
	public static string ToEnglishNumbers(this string input) {
		if (string.IsNullOrEmpty(input))
			return null;

		var stringBuilder = new StringBuilder(input);
		var mapper = new Dictionary<string, string>()
		{
			{"۱", "1"}, {"۲", "2"}, {"۳", "3"},
			{"۴", "4"}, {"۵", "5"}, {"۶", "6"},
			{"۷", "7"}, {"۸", "8"}, {"۹", "9"},
			{"۰", "0"}
		};

		foreach (var pair in mapper) {
			stringBuilder.Replace(pair.Key, pair.Value);
		}

		return stringBuilder.ToString();
	}
	public static string ToPersianContent(this string input) {
		if (string.IsNullOrEmpty(input))
			return input;

		var stringBuilder = new StringBuilder(input.Trim());
		var mapper = new Dictionary<string, string>
		{
			{"ﺎ", "ا"}, {"ﺑ", "ب"}, {"ﭘ", "پ"}, {"ﺘ", "ت"}, {"ﺟ", "ج"}, {"ﺤ", "ح"}, {"ﺦ", "خ"},
			{"ﺪ", "د"}, {"ڋ", "د"}, {"ڈ", "د"}, {"ډ", "د"}, {"ڊ", "د"}, {"ڍ", "د"}, {"ڎ", "د"},
			{"ڏ", "د"}, {"ڐ", "د"}, {"ﺬ", "ذ"}, {"ڌ", "د"}, {"ر", "ر"}, {"ﺰ", "ز"}, {"ﺴ", "س"},
			{"ﺸ", "ش"}, {"ﺻ", "ص"}, {"ﺿ", "ض"}, {"ﻂ", "ط"}, {"ﻈ", "ظ"}, {"ﻊ", "ع"}, {"ﻎ", "غ"},
			{"ﻒ", "ف"}, {"ﻘ", "ق"}, {"ک", "ک"}, {"ك", "ک"}, {"ﮔ", "گ"}, {"ﻞ", "ل"}, {"ﻼ", "لا"},
			{"ﻤ", "م"}, {"ن", "ن"}, {"ﻮ", "و"}, {"ٶ", "و"}, {"ﻫ", "ه"}, {"ؤ", "و"}, {"ٷ", "و"},
			{"ﯽ", "ی"}, {"ﻴ", "ی"}, {"ﺌ", "ئ"}, {"ي", "ی"}
		};

		foreach (var pair in mapper) {
			stringBuilder.Replace(pair.Key, pair.Value);
		}

		return stringBuilder.ToString();
	}
	public static string GetDisplayName(this Enum val)
	{
		return val.GetType().GetMember(val.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
	}
}
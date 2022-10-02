namespace Learning.Asp.Net.Core2.Domain;

using System.ComponentModel.DataAnnotations;

public enum PublisherEnum
{
    [Display(Name = "翔泳社")]
    Shoeisha,
    [Display(Name = "秀和システム")]
    Shuwa,
    [Display(Name = "技術評論社")]
    Gihyo,
    [Display(Name = "日経BP")]
    Bp,
    [Display(Name = "SBクリエイティブ")]
    Sb
}

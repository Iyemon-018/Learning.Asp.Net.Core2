namespace Learning.Asp.Net.Core2.Filters;

using Microsoft.AspNetCore.Mvc.Filters;

// OnGet や OnPost など、ハンドラの前後などで共通の処理を実行するための仕組みがフィルター
// 非同期の IAsyncPageFilter も用意されている。
public sealed class LogFilter : IPageFilter
{
    // それぞれのメソッドの引数はフィルターのコンテキスト情報
    // ページ本体やハンドラーなどの情報を管理している。

    // ハンドラーの実行前（バインド前）に呼び出される。
    public void OnPageHandlerSelected(PageHandlerSelectedContext context)
    {
        Console.WriteLine($"{nameof(OnPageHandlerSelected)}: Area[{context.ActionDescriptor.AreaName}] DisplayName[{context.ActionDescriptor.DisplayName}]");
    }

    // ハンドラーの実行前（バインド後）に呼び出される。
    public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
    {
        Console.WriteLine($"{nameof(OnPageHandlerExecuting)}: Area[{context.ActionDescriptor.AreaName}] DisplayName[{context.ActionDescriptor.DisplayName}]");
    }

    // ハンドラー実行後に呼び出される。
    public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
    {
        Console.WriteLine($"{nameof(OnPageHandlerExecuted)}: Area[{context.ActionDescriptor.AreaName}] DisplayName[{context.ActionDescriptor.DisplayName}]");
    }
}

// 特定のページに対して明示的に以下のような属性を指定することでフィルターを設定することもできる。
// 属性なので引数には定数しか入れられないが、それを許容できるならあり。
//public class LogFilterAttribute : ResultFilterAttribute
//{

//}
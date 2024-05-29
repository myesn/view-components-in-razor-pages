using Microsoft.AspNetCore.Mvc;

namespace RazorPageTests.Pages.Shared.Components.Card
{
    public class CardViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string? title = null, string titleFontColor = "#000")
        {
            var defaultCardInfo = new CardInfoModel
            {
                Title = title ?? "default",
                TitleFontColor = titleFontColor
            };

            // 传递给视图的数据，model 类型为视图页面 @model 使用的类型
            return Task.FromResult<IViewComponentResult>(View(defaultCardInfo));
        }

        public class CardInfoModel
        {
            public string Title { get; set; }
            public string TitleFontColor { get; set; }
        }
    }
}

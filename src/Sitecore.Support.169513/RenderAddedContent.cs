namespace Sitecore.Support.Mvc.Pipelines.Response.RenderPlaceholder
{
    public class RenderAddedContent : Sitecore.Mvc.Pipelines.Response.RenderPlaceholder.RenderAddedContent
    {
        public override void Process(Sitecore.Mvc.Pipelines.Response.RenderPlaceholder.RenderPlaceholderArgs args)
        {
            if (args != null && args.OwnerRendering != null && args.OwnerRendering.Properties != null)
            {
                base.Process(args);
            }
        }
    }
}
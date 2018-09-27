using Sitecore.XA.Foundation.Mvc.Repositories.Base;
namespace Sitecore.Feature.SimpleComponent.Repositories
{
    public interface ISimpleComponentRepository : IModelRepository
    {
    }

    public class SimpleComponentRepository : ModelRepository, ISimpleComponentRepository
    {
        private string Title => this.Rendering.Item?[Template._Title.Fields.Title];

        public override IRenderingModelBase GetModel()
        {
            var model = new Models.SimpleComponentModel();
            FillBaseProperties(model);
            model.Title = Title;
            return model;
        }
    }
}
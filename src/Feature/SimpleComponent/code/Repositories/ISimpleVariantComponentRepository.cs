using Sitecore.Feature.SimpleComponent.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Sitecore.Feature.SimpleComponent.Repositories
{
    public interface ISimpleVariantComponentRepository : IVariantsRepository
    {
    }

    public class SimpleVariantComponentRepository : VariantsRepository, ISimpleVariantComponentRepository
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new SimpleVariantComponentModel();
            FillBaseProperties(model);
            model.Title = "This is just an example rendering";
            return model;
        }
    }
}
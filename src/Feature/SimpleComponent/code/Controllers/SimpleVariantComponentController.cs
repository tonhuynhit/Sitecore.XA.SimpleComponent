using Sitecore.Feature.SimpleComponent.Repositories;
using Sitecore.XA.Foundation.RenderingVariants.Controllers;

namespace Sitecore.Feature.SimpleComponent.Controllers
{
    public class SimpleVariantComponentController : VariantsController
    {
        private readonly ISimpleVariantComponentRepository _simpleVariantRepository;
        public SimpleVariantComponentController(ISimpleVariantComponentRepository simpleVariantRepository)
        {
            this._simpleVariantRepository = simpleVariantRepository;
        }

        protected override object GetModel()
        {
            return this._simpleVariantRepository.GetModel();
        }
    }
}
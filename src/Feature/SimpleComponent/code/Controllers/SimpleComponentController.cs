using Sitecore.Feature.SimpleComponent.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Sitecore.Feature.SimpleComponent.Controllers
{
    public class SimpleComponentController : StandardController
    {
        private readonly ISimpleComponentRepository _repository;

        public SimpleComponentController(ISimpleComponentRepository repository)
        {
            _repository = repository;
        }

        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}
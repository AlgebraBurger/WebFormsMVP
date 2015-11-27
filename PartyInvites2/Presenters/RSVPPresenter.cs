using PartyInvites2.Models;
using PartyInvites2.Models.Repository;
using PartyInvites2.Presenters.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites2.Presenters
{
    public class RSVPPresenter : IPresenter<GuestResponse>, IPresenter<IEnumerable<GuestResponse>>
    {
        [Ninject.Inject]
        public IRepository repository { get; set; }

        IResult IPresenter<GuestResponse>.GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }
        IResult IPresenter<GuestResponse>.GetResult(GuestResponse requestData)
        {
            repository.AddResponse(requestData);
            if (!requestData.WillAttend.HasValue)
            {
                throw new System.ArgumentNullException("WillAttend");
            }
            else if (requestData.WillAttend.Value)
            {
                return new RedirectResult("/Content/seeyouthere.html");
            }
            else
            {
                return new RedirectResult("/Content/sorryyoucantcome.html");
            }
        }

        IResult IPresenter<IEnumerable<GuestResponse>>.GetResult()
        {
            return new DataResult<IEnumerable<GuestResponse>>(repository.GetAllResponses());
        }

        IResult IPresenter<IEnumerable<GuestResponse>>.GetResult(IEnumerable<GuestResponse> requestData)
        {
            throw new System.NotImplementedException();
        }
    }
}

using gov.uk.pds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Services
{
    public class BusinessAppServices
    {
        private IMemberRepository _memberRepository;
        private IBusinessItemRepository _businessItemRepository;

        public BusinessAppServices(IMemberRepository memberRepository, IBusinessItemRepository businessItemRepository)
        {
            _memberRepository = memberRepository;
            _businessItemRepository = businessItemRepository;
        }
        public IEnumerable<BusinessItem> GetCurrentWeekBusinessItems() {

            var days = DateTime.Today.DayOfWeek - DayOfWeek.Sunday;
            var weekStart = DateTime.Today.AddDays(-days);
            var weekEnd = weekStart.AddDays(6);

            return GetAllBusinessItems().Result.Where(h => h.StartDate <= weekEnd && h.EndDate >= weekStart);
        }
        public async Task<IEnumerable<BusinessItem>> GetAllBusinessItems()
        {
            return await _businessItemRepository.FindAll();
        }

        public BusinessItem GetBusinessItemBy(int id)
        {
            return _businessItemRepository.Find(id);
        }
        public IEnumerable<Member> GetAllMembersInBusinessItem(int memberId)
        {
            return GetAllBusinessItems().Result
                  .SelectMany(
                      m => m.Members
                      .Where(i => i.Id == memberId)
                   );
        }
    }
}

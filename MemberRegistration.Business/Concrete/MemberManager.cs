using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.KpsServiceReference;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager:IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        public void Add(Member member)
        {
            CheckIfMemberExists(member);
            CheckIfUserValidFromKps(member);
            _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil.");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("Bu kullanıcı daha önce kayıt olmuştur");
            }
        }
    }
}

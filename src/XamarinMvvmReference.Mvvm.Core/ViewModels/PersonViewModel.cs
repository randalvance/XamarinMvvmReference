using MvvmCross.Core.ViewModels;
using System;
using XamarinMvvmReference.Models;
using XamarinMvvmReference.Services;

namespace XamarinMvvmReference.Mvvm.Core.ViewModels
{
    public class PersonViewModel : MvxViewModel
    {
        private Person person;

        private readonly IPersonService personService;

        public PersonViewModel(IPersonService personService)
        {
            this.personService = personService;
        }

        public override void Start()
        {
            base.Start();
        }

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            var personId = Guid.Parse(parameters.Data["entityId"]);

            person = personService.Retrieve(personId);
        }

        public string FirstName
        {
            get { return person.FirstName; }
            set
            {
                person.FirstName = value;
                RaisePropertyChanged(() => FirstName);
            }
        }

        public string LastName
        {
            get { return person.LastName; }
            set
            {
                person.LastName = value;
                RaisePropertyChanged(() => LastName);
            }
        }
    }
}

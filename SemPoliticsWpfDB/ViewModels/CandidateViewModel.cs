﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Politics;

namespace SemPoliticsWpfDB.ViewModels
{
    class CandidateViewModel : BaseViewModel,IEquatable<CandidateViewModel>
    {
        public Candidate Candidate { get; set; }
        private PoliticsDBContext _dbcontext;

        public CandidateViewModel(Candidate candidate, PoliticsDBContext dbcontext)
        {
            this.Candidate = candidate;
            this._dbcontext = dbcontext;            
        }

        public string ImageSrc
        {
            get { return Candidate.ImageSrc; }
            set { Candidate.ImageSrc = value; }
        }
        public string Name
        {
            get { return Candidate.Name; }
            set { Candidate.Name = value; }
        }
        


        public bool Equals(CandidateViewModel other)
        {
            return Candidate.Equals(other.Candidate);
        }
    }
    class CandidateOnElectionViewModel : CandidateViewModel
    {
        public CandidateOnElectionViewModel(CandidateOnElection candidateItem, PoliticsDBContext dbcontext) : base(candidateItem.Candidate, dbcontext)
        {
            Candidate = candidateItem.Candidate;
            CandidateOnElection = candidateItem;
        }
        public CandidateOnElection CandidateOnElection {get;set;}
        public int Votes { get { return CandidateOnElection.VotesForCandidate; }
            set
            {
                CandidateOnElection.VotesForCandidate = value;
                OnPropertyChanged("Votes");
            }
        }
    }
}

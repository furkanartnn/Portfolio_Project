﻿using Business_Layer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}

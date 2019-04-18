using QuestionCreation.Web.Data.Entities;
using QuestionCreation.Web.Domain.ViewModel;
using System.Collections.Generic;

namespace QuestionCreation.Web.AdminUI.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<List<Answer>, AnswerViewModel>().ForMember(
                    dest => dest.Answers,
                    opt => opt.MapFrom(src => src));

                config.CreateMap<List<Question>, QuestionViewModel>().ForMember(
                    dest => dest.Questions,
                    opt => opt.MapFrom(src => src));

                config.CreateMap<List<Quiz>, QuizViewModel>().ForMember(
                    dest => dest.Quizzes,
                    opt => opt.MapFrom(src => src));

                config.CreateMap<List<User>, UserViewModel>().ForMember(
                    dest => dest.Users,
                    opt => opt.MapFrom(src => src)); 
                
            });
        }
    }
}
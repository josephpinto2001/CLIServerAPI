using AutoMapper;
using CLIServer.Dtos;
using CLIServer.Models;

namespace CLIServer.Profiles{
    public class CommandsProfile : Profile{
        public CommandsProfile()
        {   
            //Source -> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<CommandUpdateDto,Command>();
            CreateMap<Command,CommandUpdateDto>();      
        }
    }
}
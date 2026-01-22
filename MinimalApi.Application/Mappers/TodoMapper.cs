using MinimalApi.Application.Inputs;
using MinimalApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApi.Application.Mapper
{
    public class TodoMapper
    {
        public Todo Map(CreateTodoInput input)
        {
            return new CreateTodoInput
            {

            }
        }
    }
}

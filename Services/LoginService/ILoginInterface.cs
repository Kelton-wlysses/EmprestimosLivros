using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprestimosLivros.Dto;
using EmprestimosLivros.Models;

namespace EmprestimosLivros.Services.LoginService
{
    public interface ILoginInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioRegisterDto usuarioRegisterDto);

    }
}
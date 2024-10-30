using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services.Interfaces;

public interface IMemberService
{
    LibraryMember GetMemberByID(int id);
    List<LibraryMember> GetAllMembers();
    void CreateMember(LibraryMember member);
    void DeleteMember(int id, bool IsSoftDelete);
}



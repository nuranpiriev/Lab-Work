using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Interfaces;

namespace LibraryManagementSystem.Services.Concretes;

public class MemberService : IMemberService
{
    public static List<LibraryMember> Members;

    public MemberService()
    {
        Members = new List<LibraryMember>();
    }
    public void CreateMember(LibraryMember member)
    {
        Members.Add(member);
    }

    public void DeleteMember(int id, bool IsSoftDelete)
    {
        int index = -1;
        for (int i = 0; i < Members.Count; i++)
        {
            if (id == Members[i].Id)
            {
                index = i;
                break;
            }
        }

    }

    public List<LibraryMember> GetAllMembers()
    {
        return Members;
    }

    public LibraryMember GetMemberByID(int id)
    {
        int index = -1;
        for (int i = 0; i < Members.Count; i++)
        {
            if (id == Members[i].Id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            return Members[index];
        }
        else
        {
            throw new Exception($"Members siyahida id ({id}) e aid uygun deyer tapilmadi.");
        }
    }
}

using Domain.Common.Enums;
using Domain.Entities.Global;
using System.Reflection;

namespace Infrastructure.Data.Seeds;

internal class ConstantSeed
{
    public static IList<ConstantEntity> InitialValues()
    {
        var constantEntities = new List<ConstantEntity>();

        Type constantType = typeof(Constants);
        MemberInfo[] membersInfo = constantType.GetMembers(BindingFlags.Public);

        foreach (var memberInfo in membersInfo)
        {
            Type enumType = (Type)memberInfo;
            var enumValues = enumType.GetEnumValues();

            foreach (var enumValue in enumValues)
            {
                object underlyingValue = Convert.ChangeType(enumValue, Enum.GetUnderlyingType(enumValue.GetType()));

                constantEntities.Add(new ConstantEntity
                {
                    Code = Convert.ToInt32(underlyingValue),
                    Type = enumType.Name,
                    Name = enumValue.ToString()!,
                });
            }
        }

        return constantEntities;
    }
}

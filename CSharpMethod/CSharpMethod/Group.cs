
namespace CSharpMethod
{
    class Group
    {
        public string groupName;
        public int maxStuCount;

        public string Info()
        {
            return $"Group : {groupName}, count : {maxStuCount}";
        }
    }
}

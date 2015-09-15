namespace linq_Aviad
{
    public class Skills
    {
        public Skills(int employeeId, int skillId, string skillName, string briefDescription)
        {
            EmployeeId = employeeId;
            SkillId = skillId;
            SkillName = skillName;
            BriefDescription = briefDescription;
        }

        private int SkillId { get; set; }

        public int EmployeeId { get; private set; }

        public string SkillName { get; private set; }

        private string BriefDescription { get; set; }
    }
}
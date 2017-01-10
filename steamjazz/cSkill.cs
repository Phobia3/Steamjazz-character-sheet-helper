namespace Steamjazz
{
    internal class cSkill
    {
        public cSkill(int Value)
        {
            BaseValue = Value;
            SkillRankValue = 0;
            AttributeBonusValue = 0;
            SkillValue = BaseValue;
        }

        private int skillValue;

        public int SkillValue
        {
            get
            {
                return skillValue;
            }
            set
            {
                if (value >= 0) skillValue = value;
            }
        }

        private int baseValue;

        public int BaseValue
        {
            get
            {
                return baseValue;
            }
            set
            {
                baseValue = value;
            }
        }

        private int attributeBonusValue;

        public int AttributeBonusValue
        {
            get
            {
                return attributeBonusValue;
            }
            set
            {
                attributeBonusValue = value;
            }
        }

        private int skillRankValue;

        public int SkillRankValue
        {
            get
            {
                return skillRankValue;
            }
            set
            {
                if (value >= 0) skillRankValue = value;
            }
        }

        public void ValueChanged()
        {
            SkillValue = BaseValue + SkillRankValue + AttributeBonusValue;
        }
    }
}
using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
	{
		public const short Id = 13;

		public string name;

		public byte level;

		public override short TypeId
		{
			get
			{
				return 13;
			}
		}

		public FightTeamMemberCharacterInformations()
		{
		}

		public FightTeamMemberCharacterInformations(double id, string name, byte level) : base(id)
		{
			this.name = name;
			this.level = level;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadUTF();
			this.level = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.name);
			writer.WriteByte(this.level);
		}
	}
}
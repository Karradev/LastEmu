using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterMinimalGuildInformations : CharacterMinimalPlusLookInformations
	{
		public const short Id = 445;

		public BasicGuildInformations guild;

		public override short TypeId
		{
			get
			{
				return 445;
			}
		}

		public CharacterMinimalGuildInformations()
		{
		}

		public CharacterMinimalGuildInformations(double id, string name, byte level, EntityLook entityLook, BasicGuildInformations guild) : base(id, name, level, entityLook)
		{
			this.guild = guild;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.guild = new BasicGuildInformations();
			this.guild.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.guild.Serialize(writer);
		}
	}
}
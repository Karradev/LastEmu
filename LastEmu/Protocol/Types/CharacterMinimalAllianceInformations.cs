using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class CharacterMinimalAllianceInformations : CharacterMinimalGuildInformations
	{
		public const short Id = 444;

		public BasicAllianceInformations alliance;

		public override short TypeId
		{
			get
			{
				return 444;
			}
		}

		public CharacterMinimalAllianceInformations()
		{
		}

		public CharacterMinimalAllianceInformations(double id, string name, byte level, EntityLook entityLook, BasicGuildInformations guild, BasicAllianceInformations alliance) : base(id, name, level, entityLook, guild)
		{
			this.alliance = alliance;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.alliance = new BasicAllianceInformations();
			this.alliance.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.alliance.Serialize(writer);
		}
	}
}
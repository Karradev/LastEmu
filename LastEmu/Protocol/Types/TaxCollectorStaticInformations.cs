using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class TaxCollectorStaticInformations
	{
		public const short Id = 147;

		public uint firstNameId;

		public uint lastNameId;

		public GuildInformations guildIdentity;

		public virtual short TypeId
		{
			get
			{
				return 147;
			}
		}

		public TaxCollectorStaticInformations()
		{
		}

		public TaxCollectorStaticInformations(uint firstNameId, uint lastNameId, GuildInformations guildIdentity)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
			this.guildIdentity = guildIdentity;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.firstNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
			this.guildIdentity = new GuildInformations();
			this.guildIdentity.Deserialize(reader);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.firstNameId);
			writer.WriteVarShort((int)this.lastNameId);
			this.guildIdentity.Serialize(writer);
		}
	}
}
using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AllianceVersatileInformations
	{
		public const short Id = 432;

		public uint allianceId;

		public uint nbGuilds;

		public uint nbMembers;

		public uint nbSubarea;

		public virtual short TypeId
		{
			get
			{
				return 432;
			}
		}

		public AllianceVersatileInformations()
		{
		}

		public AllianceVersatileInformations(uint allianceId, uint nbGuilds, uint nbMembers, uint nbSubarea)
		{
			this.allianceId = allianceId;
			this.nbGuilds = nbGuilds;
			this.nbMembers = nbMembers;
			this.nbSubarea = nbSubarea;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.allianceId = reader.ReadVarUhInt();
			this.nbGuilds = reader.ReadVarUhShort();
			this.nbMembers = reader.ReadVarUhShort();
			this.nbSubarea = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.allianceId);
			writer.WriteVarShort((int)this.nbGuilds);
			writer.WriteVarShort((int)this.nbMembers);
			writer.WriteVarShort((int)this.nbSubarea);
		}
	}
}
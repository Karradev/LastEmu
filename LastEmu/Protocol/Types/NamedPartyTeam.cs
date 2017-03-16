using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class NamedPartyTeam
	{
		public const short Id = 469;

		public sbyte teamId;

		public string partyName;

		public virtual short TypeId
		{
			get
			{
				return 469;
			}
		}

		public NamedPartyTeam()
		{
		}

		public NamedPartyTeam(sbyte teamId, string partyName)
		{
			this.teamId = teamId;
			this.partyName = partyName;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.teamId = reader.ReadSByte();
			this.partyName = reader.ReadUTF();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.teamId);
			writer.WriteUTF(this.partyName);
		}
	}
}
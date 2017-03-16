using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayTaxCollectorFightRequestMessage : NetworkMessage
	{
		public const uint Id = 5954;

		public int taxCollectorId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5954;
			}
		}

		public GameRolePlayTaxCollectorFightRequestMessage()
		{
		}

		public GameRolePlayTaxCollectorFightRequestMessage(int taxCollectorId)
		{
			this.taxCollectorId = taxCollectorId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.taxCollectorId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.taxCollectorId);
		}
	}
}
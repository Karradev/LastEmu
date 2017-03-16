using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AreaFightModificatorUpdateMessage : NetworkMessage
	{
		public const uint Id = 6493;

		public int spellPairId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6493;
			}
		}

		public AreaFightModificatorUpdateMessage()
		{
		}

		public AreaFightModificatorUpdateMessage(int spellPairId)
		{
			this.spellPairId = spellPairId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellPairId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.spellPairId);
		}
	}
}
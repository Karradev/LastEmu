using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorMovementMessage : NetworkMessage
	{
		public const uint Id = 5633;

		public sbyte movementType;

		public TaxCollectorBasicInformations basicInfos;

		public double playerId;

		public string playerName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5633;
			}
		}

		public TaxCollectorMovementMessage()
		{
		}

		public TaxCollectorMovementMessage(sbyte movementType, TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
		{
			this.movementType = movementType;
			this.basicInfos = basicInfos;
			this.playerId = playerId;
			this.playerName = playerName;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.movementType = reader.ReadSByte();
			this.basicInfos = new TaxCollectorBasicInformations();
			this.basicInfos.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
			this.playerName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.movementType);
			this.basicInfos.Serialize(writer);
			writer.WriteVarLong(this.playerId);
			writer.WriteUTF(this.playerName);
		}
	}
}
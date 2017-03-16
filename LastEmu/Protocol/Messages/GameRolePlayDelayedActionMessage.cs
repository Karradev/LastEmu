using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayDelayedActionMessage : NetworkMessage
	{
		public const uint Id = 6153;

		public double delayedCharacterId;

		public sbyte delayTypeId;

		public double delayEndTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6153;
			}
		}

		public GameRolePlayDelayedActionMessage()
		{
		}

		public GameRolePlayDelayedActionMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime)
		{
			this.delayedCharacterId = delayedCharacterId;
			this.delayTypeId = delayTypeId;
			this.delayEndTime = delayEndTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.delayedCharacterId = reader.ReadDouble();
			this.delayTypeId = reader.ReadSByte();
			this.delayEndTime = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.delayedCharacterId);
			writer.WriteSByte(this.delayTypeId);
			writer.WriteDouble(this.delayEndTime);
		}
	}
}
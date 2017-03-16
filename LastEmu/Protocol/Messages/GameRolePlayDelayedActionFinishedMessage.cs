using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayDelayedActionFinishedMessage : NetworkMessage
	{
		public const uint Id = 6150;

		public double delayedCharacterId;

		public sbyte delayTypeId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6150;
			}
		}

		public GameRolePlayDelayedActionFinishedMessage()
		{
		}

		public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, sbyte delayTypeId)
		{
			this.delayedCharacterId = delayedCharacterId;
			this.delayTypeId = delayTypeId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.delayedCharacterId = reader.ReadDouble();
			this.delayTypeId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.delayedCharacterId);
			writer.WriteSByte(this.delayTypeId);
		}
	}
}
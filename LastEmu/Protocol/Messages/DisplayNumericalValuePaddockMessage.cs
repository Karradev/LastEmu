using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DisplayNumericalValuePaddockMessage : NetworkMessage
	{
		public const uint Id = 6563;

		public int rideId;

		public int @value;

		public sbyte type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6563;
			}
		}

		public DisplayNumericalValuePaddockMessage()
		{
		}

		public DisplayNumericalValuePaddockMessage(int rideId, int value, sbyte type)
		{
			this.rideId = rideId;
			this.@value = value;
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.rideId = reader.ReadInt();
			this.@value = reader.ReadInt();
			this.type = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.rideId);
			writer.WriteInt(this.@value);
			writer.WriteSByte(this.type);
		}
	}
}
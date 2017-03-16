using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountInformationRequestMessage : NetworkMessage
	{
		public const uint Id = 5972;

		public double id;

		public double time;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5972;
			}
		}

		public MountInformationRequestMessage()
		{
		}

		public MountInformationRequestMessage(double id, double time)
		{
			this.id = id;
			this.time = time;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
			this.time = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
			writer.WriteDouble(this.time);
		}
	}
}
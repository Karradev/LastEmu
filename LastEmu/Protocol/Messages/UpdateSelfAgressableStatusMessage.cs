using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class UpdateSelfAgressableStatusMessage : NetworkMessage
	{
		public const uint Id = 6456;

		public sbyte status;

		public int probationTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6456;
			}
		}

		public UpdateSelfAgressableStatusMessage()
		{
		}

		public UpdateSelfAgressableStatusMessage(sbyte status, int probationTime)
		{
			this.status = status;
			this.probationTime = probationTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.status = reader.ReadSByte();
			this.probationTime = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.status);
			writer.WriteInt(this.probationTime);
		}
	}
}
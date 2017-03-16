using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountRidingMessage : NetworkMessage
	{
		public const uint Id = 5967;

		public bool isRiding;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5967;
			}
		}

		public MountRidingMessage()
		{
		}

		public MountRidingMessage(bool isRiding)
		{
			this.isRiding = isRiding;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.isRiding = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.isRiding);
		}
	}
}
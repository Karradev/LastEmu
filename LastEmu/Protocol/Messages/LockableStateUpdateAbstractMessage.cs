using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LockableStateUpdateAbstractMessage : NetworkMessage
	{
		public const uint Id = 5671;

		public bool locked;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5671;
			}
		}

		public LockableStateUpdateAbstractMessage()
		{
		}

		public LockableStateUpdateAbstractMessage(bool locked)
		{
			this.locked = locked;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.locked = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.locked);
		}
	}
}
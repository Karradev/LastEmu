using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class BasicNoOperationMessage : NetworkMessage
	{
		public const uint Id = 176;

		public override uint ProtocolId
		{
			get
			{
				return (uint)176;
			}
		}

		public BasicNoOperationMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}
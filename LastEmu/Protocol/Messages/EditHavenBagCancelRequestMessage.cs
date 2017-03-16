using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EditHavenBagCancelRequestMessage : NetworkMessage
	{
		public const uint Id = 6619;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6619;
			}
		}

		public EditHavenBagCancelRequestMessage()
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
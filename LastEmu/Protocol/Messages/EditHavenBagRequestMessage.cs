using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EditHavenBagRequestMessage : NetworkMessage
	{
		public const uint Id = 6626;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6626;
			}
		}

		public EditHavenBagRequestMessage()
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
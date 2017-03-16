using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EditHavenBagStartMessage : NetworkMessage
	{
		public const uint Id = 6632;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6632;
			}
		}

		public EditHavenBagStartMessage()
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
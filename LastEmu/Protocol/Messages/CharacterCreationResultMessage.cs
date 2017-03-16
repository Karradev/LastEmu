using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterCreationResultMessage : NetworkMessage
	{
		public const uint Id = 161;

		public sbyte result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)161;
			}
		}

		public CharacterCreationResultMessage()
		{
		}

		public CharacterCreationResultMessage(sbyte result)
		{
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.result);
		}
	}
}
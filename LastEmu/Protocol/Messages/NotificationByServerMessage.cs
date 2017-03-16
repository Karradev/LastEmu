using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class NotificationByServerMessage : NetworkMessage
	{
		public const uint Id = 6103;

		public uint id;

		public string[] parameters;

		public bool forceOpen;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6103;
			}
		}

		public NotificationByServerMessage()
		{
		}

		public NotificationByServerMessage(uint id, string[] parameters, bool forceOpen)
		{
			this.id = id;
			this.parameters = parameters;
			this.forceOpen = forceOpen;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.parameters = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.parameters[i] = reader.ReadUTF();
			}
			this.forceOpen = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
			writer.WriteShort((short)((int)this.parameters.Length));
			string[] strArrays = this.parameters;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
			writer.WriteBoolean(this.forceOpen);
		}
	}
}
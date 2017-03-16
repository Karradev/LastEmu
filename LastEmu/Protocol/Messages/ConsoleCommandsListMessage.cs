using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ConsoleCommandsListMessage : NetworkMessage
	{
		public const uint Id = 6127;

		public string[] aliases;

		public string[] args;

		public string[] descriptions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6127;
			}
		}

		public ConsoleCommandsListMessage()
		{
		}

		public ConsoleCommandsListMessage(string[] aliases, string[] args, string[] descriptions)
		{
			this.aliases = aliases;
			this.args = args;
			this.descriptions = descriptions;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.aliases = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.aliases[i] = reader.ReadUTF();
			}
			num = reader.ReadUShort();
			this.args = new string[num];
			for (int j = 0; j < num; j++)
			{
				this.args[j] = reader.ReadUTF();
			}
			num = reader.ReadUShort();
			this.descriptions = new string[num];
			for (int k = 0; k < num; k++)
			{
				this.descriptions[k] = reader.ReadUTF();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.aliases.Length));
			string[] strArrays = this.aliases;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
			writer.WriteShort((short)((int)this.args.Length));
			string[] strArrays1 = this.args;
			for (int j = 0; j < (int)strArrays1.Length; j++)
			{
				writer.WriteUTF(strArrays1[j]);
			}
			writer.WriteShort((short)((int)this.descriptions.Length));
			string[] strArrays2 = this.descriptions;
			for (int k = 0; k < (int)strArrays2.Length; k++)
			{
				writer.WriteUTF(strArrays2[k]);
			}
		}
	}
}